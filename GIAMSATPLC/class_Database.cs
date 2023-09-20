using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient; // Thư viện SQL
namespace GIAMSATPLC
{
    public static class class_Database
    {
        // Ghi dữ liệu xuống SQL (4 cột)
        public static void cmd_SQLWrite(string sqltable_name,
                                        string collum1, string data1,
                                        string collum2, string data2,
                                        string collum3, string data3,
                                        string collum4, string data4)
        {
            SqlConnection sql_conn; // Khởi tạo tên kết nối SQL

            try
            {
                string DB_Name = Properties.Settings.Default.SQL_DBName;
                string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                                 + DB_Name + ";Integrated Security=True";
                sql_conn = new SqlConnection(sqlName);
                sql_conn.Open();
                string sql = " INSERT INTO " + sqltable_name + " ("
                    + collum1 + ","
                    + collum2 + ","
                    + collum3 + ","
                    + collum4 + ")"
                    + " VALUES "
                    + "("
                    + "@" + collum1 + ","
                    + "@" + collum2 + ","
                    + "@" + collum3 + ","
                    + "@" + collum4 + ")";
                using (SqlCommand cmd = new SqlCommand(sql, sql_conn))
                {
                    cmd.Parameters.AddWithValue(collum1, data1);
                    cmd.Parameters.AddWithValue(collum2, data2);
                    cmd.Parameters.AddWithValue(collum3, data3);
                    cmd.Parameters.AddWithValue(collum4, data4);
                    cmd.ExecuteNonQuery();
                }
                sql_conn.Close();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi ở đây
                MessageBox.Show("Lỗi khi ghi dữ liệu vào SQL: " + ex.Message);
            }
        }
        // Hiển thị lên data grid view
        public static void sqlDisplay(string sqlSelect, DataGridView dtgr)
        {
            SqlConnection sql_conn; // Khởi tạo tên kết nối SQL
            string DB_Name = Properties.Settings.Default.SQL_DBName;
            string sqlName = @"Data Source=(local)\SQLEXPRESS;Initial Catalog="
                             + DB_Name + ";Integrated Security=True";
            sql_conn = new SqlConnection(sqlName);
            sql_conn.Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, sql_conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dtgr.DataSource = dt;
            dtgr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sql_conn.Close();
        }
    }
}
