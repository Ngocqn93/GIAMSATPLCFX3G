using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace GIAMSATPLCFX3G
{
    // Xuất Excel
    public class class_Excel_Export
    {
        // Hàm thực hiện xuất Excel
        public void Execute(DateTimePicker dtpk_DateStart,
                            DateTimePicker dtpk_TimeStart,
                            DateTimePicker dtpk_DateEnd,
                            DateTimePicker dtpk_TimeEnd )
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi missing thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;
                object misValue = System.Reflection.Missing.Value;
                Workbook wb = xlApp.Workbooks.Add(misValue);
                Worksheet ws = (Worksheet)wb.Worksheets[1];
                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1; // Khai báo hàng bắt đầu của Sheet
                //=======================THIẾT KẾ PHẦN HEADER=====================
                // Hình ảnh logo
                var imgRange = (Microsoft.Office.Interop.Excel.Range)ws.Cells[1, 1];
                Microsoft.Office.Interop.Excel.Range oRange = imgRange;
                string imgPath = "C:\\Users\\NGOCNGUYEN\\Desktop\\ht.png";
                const float Height = 50;
                const float Width = 50;
                float Left = (float)((double)oRange.Left);
                float Top = (float)((double)oRange.Top);
                var mso = Microsoft.Office.Core.MsoTriState.msoFalse;
                var msoCTrue = Microsoft.Office.Core.MsoTriState.msoCTrue;
                ws.Shapes.AddPicture(imgPath, mso, msoCTrue, Left, Top, Height, Width);
                // Tên & thông tin công ty
                Range company_Name = ws.get_Range("B2");
                Range Adress = ws.get_Range("B3");
                Range Contact = ws.get_Range("B4");
                company_Name.Value2 = "CÔNG TY TNHH DỊCH VỤ THƯƠNG MẠI HOÀNG TRƯỜNG";
                Adress.Value2 = "Địa chỉ : P.An Bình,TP Biên Hòa ";
                Contact.Value2 = "Hotline: +84 904 701 605";
                company_Name.Font.Size = 14;
                company_Name.Font.Name = "Times New Roman";
                company_Name.Font.Bold = true;
                // Xuất ngày/giờ in báo cáo
                Range printtime = ws.get_Range("E4");
                string actime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                string printtimest = "Ngày tháng: " + actime;
                printtime.Value2 = printtimest;
                //Xuất dòng Tiêu đề
                Range tittle = ws.get_Range("A5", "F5");
                tittle.Value2 = "BÁO CÁO SẢN XUẤT";
                tittle.Merge();
                tittle.Font.Size = 14;
                tittle.Font.Name = "Times New Roman";
                var alignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                tittle.Cells.HorizontalAlignment = alignment;
                //Tạo ô Số Thứ Tự (STT)
                Range STT = ws.get_Range("A6");
                STT.Value2 = "STT";
                STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                STT.ColumnWidth = 10;
                //Tạo ô Thời gian
                Range sTime = ws.get_Range("B6");
                sTime.Value2 = "Thời gian";
                sTime.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sTime.ColumnWidth = 20;             
                //Tạo ô giá trị integer
                Range tag_Int = ws.get_Range("C6");
                tag_Int.Value2 = "Mã lỗi PLC";
                tag_Int.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Int.ColumnWidth = 20;
                //Tạo ô giá trị text
                Range tag_text = ws.get_Range("D6");
                tag_text.Value2 = "Trạng thái PLC";
                tag_text.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_text.ColumnWidth = 20;
                //Tạo ô tọa độ
                Range tag_Real = ws.get_Range("E6");
                tag_Real.Value2 = "Tọa độ Servo";
                tag_Real.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                tag_Real.ColumnWidth = 20;
                //Tạo ô ghi chú
                Range note = ws.get_Range("F6");
                note.Value2 = "Ghi chú";
                note.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                note.ColumnWidth = 20;
                //Tô nền vàng các cột tiêu đề:
                Range tittle_style = ws.get_Range("A5", "F6");
                var backcolor = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                var fomtcolor = ColorTranslator.ToOle(System.Drawing.Color.Black);
                tittle_style.Interior.Color = backcolor;
                tittle_style.Font.Color = fomtcolor;
                tittle_style.Font.Bold = true;
                //=======================XUẤT CƠ SỞ DỮ LIỆU=====================
                // Lựa chọn tìm kiếm
                // Theo khoảng thời gian
                string Date_Start = dtpk_DateStart.Value.ToString("yyyy-MM-dd");
                string Time_Start = dtpk_TimeStart.Value.ToString("HH:mm:ss");
                string Date_End = dtpk_DateEnd.Value.ToString("yyyy-MM-dd");
                string Time_End = dtpk_TimeEnd.Value.ToString("HH:mm:ss");

                string Srange1 = Date_Start + " " + Time_Start;
                string Erange1 = Date_End + " " + Time_End;

                // Khởi tạo datalist array
                report_excelDataContext database = new report_excelDataContext();
                var datalist = from tb in database.FX3GA_Datas
                               select new
                               {
                                   col1 = tb.date_time.ToString(),
                                   col2 = tb.data_Integer,
                                   col3 = tb.data_Text,
                                   col4 = tb.data_Real
                               };
                int stt = 0;
                row = 6; //Bắt đầu xuất từ dòng số 7
                foreach (var element in datalist)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, element.col1, element.col2, element.col3, element.col4 };
                    Range rowData = ws.get_Range("A" + row, "E" + row);
                    rowData.Font.Size = 11;
                    rowData.Font.Name = "Times New Roman";
                    rowData.Value2 = arr;
                }
                //=======================TẠO TRƯỜNG CHỮ KÝ=====================
                //Tạo ô chữ ký
                int signrow = row + 2;
                int signnote = signrow + 1;

                // Người ký 1
                string signpos1 = "B" + signrow;
                string signnotepos1 = "B" + signnote;

                Range sign1 = ws.get_Range(signpos1);
                sign1.Value2 = "Giám đốc";
                sign1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sign1.Font.Bold = true;

                Range signnote1 = ws.get_Range(signnotepos1);
                signnote1.Value2 = "(Ký ghi rõ họ tên)";
                signnote1.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // Người ký 2
                string signpos2 = "D" + signrow;
                string signnotepos2 = "D" + signnote;

                Range sign2 = ws.get_Range(signpos2);
                sign2.Value2 = "Trưởng ca";
                sign2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sign2.Font.Bold = true;

                Range signnote2 = ws.get_Range(signnotepos2);
                signnote2.Value2 = "(Ký ghi rõ họ tên)";
                signnote2.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // Người ký 3
                string signpos3 = "F" + signrow;
                string signnotepos3 = "F" + signnote;

                Range sign3 = ws.get_Range(signpos3);
                sign3.Value2 = "Người in biểu";
                sign3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                sign3.Font.Bold = true;

                Range signnote3 = ws.get_Range(signnotepos3);
                signnote3.Value2 = "(Ký ghi rõ họ tên)";
                signnote3.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                // ================CÁC PHẦN THIẾT KẾ KHÁC===================
                class_Excel.BorderAround(ws.get_Range("A5", "F" + row));
                // Step 1: Lưu file excel xuống Ổ cứng
                string datetimenow = DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss");
                string saveExcelFile = @"d:\Excel_Report_" + datetimenow + ".xlsx";
                wb.SaveAs(saveExcelFile);
                //Step 2: Đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //Step 3: Thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                class_Excel.releaseObject(ws);
                class_Excel.releaseObject(wb);
                class_Excel.releaseObject(xlApp);
                //Step 4: Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    // ================== CÁC HÀM MẶC ĐỊNH ====================
    public static class class_Excel
    {
        //Hàm kẻ khung cho Excel (mặc định)
        public static void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel (Mặc định)
        public static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
    }
}