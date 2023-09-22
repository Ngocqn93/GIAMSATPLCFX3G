using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GIAMSATPLCFX3G
{
    public partial class form_Report : Form
    {
        public form_Report()
        {
            InitializeComponent();
        }
        // Gọi hàm lấy dữ liệu từ form chính (Main)
        public string rpDatetime_Start;
        public string rpDatetime_End;
        public string rpShift_Search_Start;
        public string rpShift_Search_End;
        
        // Form load
        private void form_Report_Load(object sender, EventArgs e)
        {
            // ++++++Cho full màn hình khi nhấn nút báo cáo (form_Report)++++++
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            // ++++++TÌM KIẾM THEO NGÀY THÁNG++++++
            
            {
                // Quy đổi giá trị thời gian sang dạng "datetime"
                DateTime DateStart = Convert.ToDateTime(rpDatetime_Start);
                DateTime DateEnd = Convert.ToDateTime(rpDatetime_End);
                // Đưa câu lệnh query sang Dataset
                this.FX3GA_DataTableAdapter.Fill(this.dssqlreport.FX3GA_Data, DateStart, DateEnd);
                this.reportViewer1.RefreshReport();
            }
            // Làm full màn hình in
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
        }

       
    }
}