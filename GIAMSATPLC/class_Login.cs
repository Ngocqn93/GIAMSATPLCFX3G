using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIAMSATPLCFX3G
{
    public class class_Login
    {
        // Disable toàn bộ khi chưa đăng nhập/ hoặc nhấn đăng xuất
        public void Not_Login()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            // Các object cần Enable/Disable
            frm.btt_SQLEdit.Enabled = false;
            
        }
        // Đăng nhập bằng quyền Admin
        public void admin_Control_Elements()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            // Các object cần Enable/Disable
            frm.btt_SQLEdit.Enabled = true;
            
        }

        // Đăng nhập bằng quyền người dùng Operator
        public void Operator_Control_Elements()
        {
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            // Các object cần Enable/Disable
            frm.btt_SQLEdit.Enabled = false;
           
        }

    }
}
