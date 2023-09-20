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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        // Gọi chương trình con đăng nhập
        class_Login fn_login = new class_Login(); // đăng nhập

        // Khai báo tên người dùng
        string user1_Name = "Admin";        // Tên người dùng 1
        string user1_Password = "123456";   // Pass người dùng 1

        string user2_Name = "User1";        // Tên người dùng 2
        string user2_Password = "123";      // Pass người dùng 2

        string user3_Name = "User2";        // Tên người dùng 3
        string user3_Password = "123";      // Pass người dùng 3

        private void btt_Login_Click(object sender, EventArgs e)
        {
            // Đăng nhập bằng Admin
            if (txt_Username.Text == user1_Name & txt_Password.Text == user1_Password)
            {
                fn_login.admin_Control_Elements();
                this.Close(); // Close fomr đăng nhập
            }
            else if (txt_Username.Text == user2_Name & txt_Password.Text == user2_Password)
            {
                fn_login.Operator_Control_Elements();
                this.Close(); // Close fomr đăng nhập
            }
            else if (txt_Username.Text == user3_Name & txt_Password.Text == user3_Password)
            {
                fn_login.Operator_Control_Elements();
                this.Close(); // Close fomr đăng nhập
            }
            else
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu");
            }
        } 
        
    }
}
