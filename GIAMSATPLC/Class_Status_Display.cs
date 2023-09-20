using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SymbolFactoryDotNet; // Thư viện symbol factory
using System.Drawing;
using System.Windows.Forms;

namespace GIAMSATPLCFX3G
{
    class Class_Status_Display
    {
        // Hiển thị nhóm 2 trạng thái - Đèn báo
        public void stt_Lamp(StandardControl st, string value)
        {
            if (value == "True")
            {
                st.DiscreteValue1 = true;
            }
            else
            {
                st.DiscreteValue1 = false;
            }
        }
    }
}
