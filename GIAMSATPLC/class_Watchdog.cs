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
    public static class class_Watchdog
    {
        static string valold = "";
        // Chương trình con Watch dog
        public static void WatchdogStatus(Button btt, string valnow)
        {
            if (valnow != valold)
            {
                btt.BackColor = Color.Green;
                btt.ForeColor = Color.White;
            }
            else
            {
                btt.BackColor = Color.Red;
                btt.ForeColor = Color.White;
            }
            valold = valnow;
        }
    }
}