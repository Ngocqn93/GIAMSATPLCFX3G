 using System; 
 using System.Collections.Generic; 
 using System.ComponentModel; 
 using System.Data; 
 using System.Drawing; 
 using System.Linq; 
 using System.Text; 
 using System.Threading.Tasks; 
 using System.Windows.Forms; 
 using OPCAutomation; // Thư viện OPC 
 using NPOI.HSSF.UserModel;// Thư viện NPOI 
 using NPOI.SS.UserModel;// Thư viện NPOI 
 using NPOI.XSSF.UserModel;// Thư viện NPOI 
using System.IO;

namespace GIAMSATPLCFX3G
{
    public partial class Form1 : Form
    {
        
        public bool isZeroCode = true; // Biến để kiểm tra xem mã số có phải là 0 hay không
        private bool IsConnected { get; set; } = false; // Thêm một thuộc tính để theo dõi trạng thái kết nối
        private bool hasError = false;
        public Form1()
        {
            InitializeComponent();
        }
        //==========================CHƯƠNG TRÌNH CON CLASS==================
        Class_Status_Display statusDisplay = new Class_Status_Display();
        class_Login fn_login = new class_Login();
        //=======================QUẢN LÝ NGƯỜI DÙNG=========================
        // Nút nhấn đăng nhập
        private void btt_Login_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login();
            loginForm.Show();
            tbx_DBName.Text = Properties.Settings.Default.SQL_DBName; //Load tên DB
        }
        // Nút nhấn đăng xuất
        private void btt_Logout_Click(object sender, EventArgs e)
        {
            fn_login.Not_Login();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbx_DBName.Text = Properties.Settings.Default.SQL_DBName; //Load tên DB
            KEPServerEX_Connect();
            btt_Check.Enabled = false; // Khởi tạo nút btt_Check ở trạng thái bị khóa
            txt_ND.Text = "PLC CHƯA KẾT NỐI VỚI OPCSERVE";
            txt_ND.Font = new Font("Arial", 9); // Thay đổi "Arial" và 12 bằng font và kích thước mong muốn.

            if (!KEPServerEX_Connect())
            {

                txt_ND.Text = "CONNECTION FAILED";
                txt_ND.Font = new Font("Arial", 9);

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btt_Connect_Click(object sender, EventArgs e)
        {
            if (IsConnected == true)
            {
                txt_ND.Text = "PLC READY";
                txt_ND.Font = new Font("Arial", 9); // Thay đổi "Arial" và 12 bằng font và kích thước mong muốn.
                btt_Check.Enabled = true;
            }
            else
            {
                // Xử lý lỗi nếu kết nối thất bại 
                btt_Check.Enabled = false;
                txt_ND.Text = "DISCONNECTED PLC";
                txt_ND.Font = new Font("Arial", 9); // Thay đổi "Arial" và 12 bằng font và kích thước mong muốn.
                MessageBox.Show("Chưa kết nối thành công OPC với PLC.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btt_Disconnect_Click(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                if (OPCServer != null)
                {
                    OPCServer.Disconnect();
                }
                OPCServer = null;
                PLC = null;
                txt_ND.Text = "DISCONNECTED PLC";
                // IsConnected sẽ đặt lại là false sau khi ngắt kết nối
                IsConnected = false;
                btt_Disconnect.Enabled = false; // Khóa nút Disconnect    
                if (KEPServerEX_Connect())
                {
                    btt_Connect.BackColor = Color.Red; // Màu đỏ nếu kết nối thất bại
                    btt_Check.Enabled = false;
                }

            }

        }
        //==========================WATCHDOG================================
        string Watchdog_value = "0"; // đọc lên tag Watchdog
        private void Timer_Watchdog_Tick_1(object sender, EventArgs e)
        {
            class_Watchdog.WatchdogStatus(btt_Connect, Watchdog_value);
            // Thêm mã kiểm tra màu nền của nút và đặt txt_ND tương ứng
            if (btt_Connect.BackColor == Color.Red && hasError != true)
            {
                txt_ND.Text = "CONNECTION FAILED";
                txt_ND.Font = new Font("Arial", 9); // Thay đổi font và kích thước mong muốn.
            }

        }
        //==========================KEPServerEX CONNECT=====================
        static int tagNumber = 27;      // Cài đặt số lượng tag của project
        static int PLCscantime = 1000;  // Cài đặt thời gian quét PLC
        // Gọi các kết nối OPC
        public OPCAutomation.OPCServer AnOPCServer; //Đây là khai báo một biến AnOPCServer kiểu OPCAutomation.OPCServer.Biến này có thể được sử dụng để đối tượng OPCServer(máy chủ OPC) liên quan đến một mục đích cụ thể.
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;//Đây là khai báo một biến PLC kiểu OPCAutomation.OPCGroup. Biến này có thể được sử dụng để lưu trữ đối tượng OPCGroup cụ thể mà bạn tạo để quản lý các tag và sự kiện liên quan đến PLC.
        public string Groupname;
        static int arrlength = tagNumber + 1;//Đây là một biến tĩnh (static variable) có tên arrlength. Biến này được khởi tạo bằng cách cộng giá trị của biến tagNumber với 1. Biến arrlength sẽ lưu trữ số lượng phần tử cần tạo cho các mảng sau đó.
        Array OPtags = class_KEPServerEX.tagread(arrlength);
        Array tagID = class_KEPServerEX.tagID(arrlength);
        Array WriteItems = Array.CreateInstance(typeof(object), arrlength);
        Array tagHandles = Array.CreateInstance(typeof(Int32), arrlength);
        Array OPCError = Array.CreateInstance(typeof(Int32), arrlength);
        Array dataType = Array.CreateInstance(typeof(Int16), arrlength);
        Array AccessPaths = Array.CreateInstance(typeof(string), arrlength);
        // Chương trình con kết nối (Connect)
        private bool KEPServerEX_Connect()
        {
            try
            {
                string IOServer = "Kepware.KEPServerEX.V6";
                string IOGroup = "OPCGroup1";
                OPCServer = new OPCAutomation.OPCServer();
                OPCServer.Connect(IOServer, "");
                PLC = OPCServer.OPCGroups.Add(IOGroup);
                PLC.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(dataScan);
                PLC.UpdateRate = PLCscantime;
                PLC.IsSubscribed = PLC.IsActive;
                PLC.OPCItems.DefaultIsActive = true;
                PLC.OPCItems.AddItems(tagNumber, ref OPtags, ref tagID,
                    out tagHandles, out OPCError, dataType, AccessPaths);

                // Cập nhật trạng thái kết nối
                IsConnected = true;
                btt_Disconnect.Enabled = true; // Mở khóa nút Disconnect
                btt_Connect.BackColor = Color.Green; // Màu xanh khi kết nối thành công

                return true; // Trả về true nếu kết nối thành công

            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi kết nối KepServerEX: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Cập nhật trạng thái kết nối
                IsConnected = false;

                return false; // Trả về false nếu có lỗi khi kết nối
            }
        }
        //==========================ĐỌC DỮ LIỆU TAG=====================
        // Khai báo tag ghi dữ liệu vào sql
        string sql_Integer;
        string sql_Real;
        private void dataScan(int ID, int NumItems, ref Array tagID,
           ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {

            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                Console.WriteLine(tagID.Length);
                // textbox

                if (getTagID == 1) // Kiểm tra lỗi
                {
                    txt_Code.Text = tagValue;
                    sql_Integer= tagValue; // Save SQL
                    
                }
                if (getTagID == 2) // TOA DO HT
                {
                    double numericValue = 0.0; // Giá trị số sau khi biến đổi
                    if (double.TryParse(tagValue, out numericValue))
                    {
                        // Chuyển giá trị thành 0.1
                        numericValue /= 10.0;
                        // Hiển thị giá trị đã biến đổi trong textbox
                        txt_VT.Text = numericValue.ToString();
                        sql_Real = tagValue;
                        
                    }
                    else
                    {
                        // Xử lý lỗi nếu không thể chuyển đổi thành số
                        // Ở đây, bạn có thể hiển thị một giá trị mặc định hoặc thông báo lỗi.
                        txt_VT.Text = "Giá trị không hợp lệ";
                    }

                }            
                // Watchdog
                if (getTagID == 3)
                {
                    Watchdog_value = tagValue;
                }
                // Đèn báo
                if (getTagID == 4)
                {
                    statusDisplay.stt_Lamp(sym_Lamp_PLC, tagValue);
                }
                if (getTagID == 16 || getTagID == 17 || getTagID == 18 || getTagID == 19 || getTagID == 20 || getTagID == 21
                     || getTagID == 22 || getTagID == 23 || getTagID == 24 || getTagID == 25 )
                {   
                    statusDisplay.stt_Lamp(sym_Lamp_Error, tagValue);                   
                }         
                // xuất dữ liệu ra SQL
                if (getTagID == 26)
                {   
                    if (tagValue == "True")
                    {
                        // Khai báo giá trị
                        string sqltable_name = "FX3GA_Data";
                        string collum1 = "date_time";
                        string collum2 = "data_Integer";
                        string collum3 = "data_Text";
                        string collum4 = "data_Real";
                        string data1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        string data2 = sql_Integer;
                        string data3 = txt_ND.Text;
                        string data4 = sql_Real;
                        if (double.TryParse(data4, out double data4Value))
                        {
                            // Chia giá trị của data4 cho 10
                            data4Value /= 10;
                            // Sau khi chia, bạn có thể gán giá trị mới vào biến data4
                            data4 = data4Value.ToString();
                        }
                        // Hàm Ghi dữ liệu
                        class_Database1.cmd_SQLWrite(sqltable_name,
                            collum1, data1,
                            collum2, data2,
                            collum3, data3,
                            collum4, data4);
                    }
                }
                if (getTagID == 8)
                {
                    statusDisplay.stt_Lamp(sym_Lamp_servorun, tagValue);
                    
                }
                if (getTagID == 27)
                {
                    
                }

            }
        }   
        public void btt_Check_Click(object sender, EventArgs e)
        {
            string excelFilePath = "C:\\Users\\NGOCNGUYEN\\source\\repos\\GIAMSATPLCFX3G\\EXCEL\\Book1.xlsx"; // Đường dẫn đến tệp Excel
            string codeToCheck = txt_Code.Text.Trim(); // Mã số để kiểm tra  
            
            try
            {
                // Tạo một luồng đọc từ tệp Excel
                IWorkbook workbook;
                using (var fileStream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
                {
                    if (excelFilePath.EndsWith("Book1.xls"))
                        workbook = new HSSFWorkbook(fileStream); // Đối với định dạng .xls
                    else
                        workbook = new XSSFWorkbook(fileStream); // Đối với định dạng .xlsx
                }
                // Lấy ra Sheet cần đọc (ở đây giả sử bạn đọc từ Sheet đầu tiên)
                ISheet sheet = workbook.GetSheetAt(0);
                // Đặt mặc định cho TextBox txt_ND là "PLC BÌNH THƯỜNG"
                txt_ND.Text = "PLC READY";
                // Kiểm tra xem mã số có phải là "0" không
                if (codeToCheck == "0")
                {
                    isZeroCode = true;
                    return; // Không cần kiểm tra lỗi khi mã số là "0"
                }
                else
                {
                    isZeroCode = false;
                }
                // Duyệt qua từng dòng trong Sheet
                foreach (IRow row in sheet)
                {
                    // Lấy giá trị mã số từ cột đầu tiên (column index = 0)
                    string cellValue = row.GetCell(0).ToString();
                    // So sánh mã số từ Excel với mã số từ TextBox
                    if (cellValue == codeToCheck)
                    {
                        // Nếu mã số khớp, hiển thị nội dung từ cột thứ hai (column index = 1)
                        txt_ND.Text = row.GetCell(1).ToString();                       
                        hasError = true;
                        return; // Kết thúc việc tìm kiếm khi tìm thấy mã số khớp
                    }
                }
                // Nếu không tìm thấy mã số khớp, đánh dấu có lỗi
                txt_ND.Text = "Lỗi không xác định!";
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_Code_Leave(object sender, EventArgs e)
        {
            string codeToCheck = txt_Code.Text.Trim();

            if (codeToCheck == "0")
            {
                isZeroCode = true;
                txt_ND.Text = "PLC READY";
                btt_Check.Enabled = false; // Khóa nút btt_Check khi mã code là 0
            }
            else
            {
                isZeroCode = false;
                btt_Check.Enabled = true; // Mở nút btt_Check khi mã code khác 0
            }
        }
        
        // Nút nhấn cho phép sửa giá trị 
        private void btt_Edit_Click(object sender, EventArgs e)
        {
            tbx_settingspeed.Enabled = true;
            tbx_settingtoado.Enabled = true;
            tbx_speedjog.Enabled = true;
        }
        // Nút nhấn lưu giá trị cài đặt 
        private double displayedValue = 0.0;
        private void btt_Save_Click(object sender, EventArgs e)
        {
            string inputValue = tbx_settingtoado.Text;

            // Chuyển đổi chuỗi đầu vào thành một số thập phân
            if (double.TryParse(inputValue, out double doubleValue))
            {
                // Lưu giá trị thập phân vào biến trung gian
                displayedValue = doubleValue;

                // Hiển thị giá trị thập phân trong TextBox
                tbx_settingtoado.Text = displayedValue.ToString("F1");

                // Ghi giá trị vào WriteItems
                int intValue = (int)(doubleValue * 10); // Chuyển đổi thành số nguyên (501)
                WriteItems.SetValue(intValue, 5); // Ghi giá trị nguyên vào WriteItems
            }
            else
            {
                // Xử lý lỗi nếu không thể chuyển đổi thành số thập phân
                MessageBox.Show("Giá trị không hợp lệ");
            }
            WriteItems.SetValue(tbx_speedjog.Text,6);
            WriteItems.SetValue(tbx_settingspeed.Text,7);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            tbx_settingspeed.Enabled = false;
            tbx_settingtoado.Enabled = false;
            tbx_speedjog.Enabled = false;           
            MessageBox.Show("Dữ liệu đã được lưu");

        }
        //==========================GHI DỮ LIỆU TAG=====================           
     
        private bool buttonPressed = false;
        public bool ButtonPressed
        {
            get { return buttonPressed; }
            set { buttonPressed = value; }
        }
        // Nút nhấn JOG+ 
        private void sym_btt_JOG2_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            WriteItems.SetValue(1, 9);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        private void sym_btt_JOG2_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            WriteItems.SetValue(0, 9);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        // Nút nhấn JOG-
        private void sym_btt_JOG3_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            WriteItems.SetValue(1, 10);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        private void sym_btt_JOG3_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            WriteItems.SetValue(0, 10);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        // Nút nhấn GOABS
        private void sym_btt_goabs_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            WriteItems.SetValue(1, 11);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        private void sym_btt_goabs_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            WriteItems.SetValue(0, 11);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        // Nút nhấn GOINC
        private void sym_btt_goinc_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            WriteItems.SetValue(1, 12);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        private void sym_btt_goinc_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            WriteItems.SetValue(0, 12);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }      
        // Nút nhấn AUTO/MAN
        private void sym_btt_Automan_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            WriteItems.SetValue(1, 15);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        private void sym_btt_Automan_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            WriteItems.SetValue(0, 15);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        // Nút nhấn HOME
        private void sym_btt_Home_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            WriteItems.SetValue(1, 13);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        private void sym_btt_Home_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            WriteItems.SetValue(0, 13);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        // Nút nhấn SETHOME
        private void sym_btt_sethome_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPressed = true;
            WriteItems.SetValue(1, 14);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        private void sym_btt_sethome_MouseUp(object sender, MouseEventArgs e)
        {
            buttonPressed = false;
            WriteItems.SetValue(0, 14);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }
        //==========================GHI DỮ LIỆU TAG=====================
        // Nút nhấn Edit SQL Database Name
        private void btt_SQLEdit_Click(object sender, EventArgs e)
        {
            tbx_DBName.Enabled = true;
            btt_SQLSave.Enabled = true;
        }
        // Nút nhấn Lưu SQL
        private void btt_SQLSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SQL_DBName = tbx_DBName.Text;//Tên Database
            Properties.Settings.Default.Save(); // Lưu vào Setting
            tbx_DBName.Enabled = false; // Disable text field
                                        // Hiện thông báo
            MessageBox.Show("Sửa thành công, Khởi động lại phần mềm để cập nhật!");
        }
        // Nút nhấn hiển thị dữ liệu bảng lên Datagridview
        private void btt_Showdata_Click(object sender, EventArgs e)
        {
            string sqlSelect = "SELECT * FROM FX3GA_Data";
            class_Database1.sqlDisplay(sqlSelect, dataGridView1);
            // Đặt tên cho các cột datagridview
            dataGridView1.Columns[0].HeaderText = "Thời gian";
            dataGridView1.Columns[2].Width = 350;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].HeaderText = "Mã lỗi PLC";
            dataGridView1.Columns[2].HeaderText = "Trạng thái PLC";
            dataGridView1.Columns[3].HeaderText = "Tọa độ hiện tại Servo (độ)";     
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
        }
        //TÌM KIẾM CƠ SỎ DỮ LIỆU
        private void btt_Search_Click(object sender, EventArgs e)
        {
            // SQL tìm kiếm theo thời gian
            string Date_Start = dtpk_DateStart.Value.ToString("yyyy-MM-dd");
            string Time_Start = dtpk_TimeStart.Value.ToString("HH:mm:ss");
            string Date_End = dtpk_DateEnd.Value.ToString("yyyy-MM-dd");
            string Time_End = dtpk_TimeEnd.Value.ToString("HH:mm:ss");
            string tablename = "FX3GA_Data"; // Bảng cần truy vấn
            string datetime_collum_name = "date_time";
            string sqlSelect = "SELECT *FROM "
                       + tablename + " where DATE_TIME between '"
                       + Date_Start + " " + Time_Start
                       + "' and '" + Date_End + " " + Time_End
                       + "' ORDER BY " + datetime_collum_name + ";";
                class_Database1.sqlDisplay(sqlSelect, dataGridView1);
            
        }
        // xuất báo cáo
        private void btt_report1_Click(object sender, EventArgs e)
        {
            // Tạo các biến string từ date time piker
            string Date_Start = dtpk_DateStart.Value.ToString("yyyy-MM-dd");
            string Time_Start = dtpk_TimeStart.Value.ToString("HH:mm:ss");
            string Date_End = dtpk_DateEnd.Value.ToString("yyyy-MM-dd");
            string Time_End = dtpk_TimeEnd.Value.ToString("HH:mm:ss");
            // Mở form xuất báo cáo (form_Report)
            form_Report frm = new form_Report();
            // Truyền dữ liệu qua form report
            frm.rpDatetime_Start = Date_Start + ' ' + Time_Start;
            frm.rpDatetime_End = Date_End + ' ' + Time_End;
            frm.Show();
        }
    }
}

