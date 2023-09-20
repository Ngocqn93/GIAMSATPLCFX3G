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
    public class class_KEPServerEX
    {
        // Class Khai báo tag
        public static string[] tagread(int tagnumber)
        {
            string tagID_1 = "Channel1.Device1.Status_Numbererror";
            string tagID_2 = "Channel1.Device1.CurrentValue";
            string tagID_3 = "Channel1.Device1.Watchdog";         
            string tagID_4 = "Channel1.Device1.Status_PLCOSTATUS";                     
            string tagID_5 = "Channel1.Device1.settingtoado";
            string tagID_6 = "Channel1.Device1.speedjog";
            string tagID_7 = "Channel1.Device1.speed";         
            string tagID_8 = "Channel1.Device1.SERVORUN";
            string tagID_9 = "Channel1.Device1.btt_JOG+";
            string tagID_10 = "Channel1.Device1.btt_JOG-";
            string tagID_11 = "Channel1.Device1.btt_GOABS";
            string tagID_12 = "Channel1.Device1.btt_GOINC";
            string tagID_13 = "Channel1.Device1.btt_HOME";
            string tagID_14 = "Channel1.Device1.btt_SETHOME";
            string tagID_15 = "Channel1.Device1.btt_AUTOMAN";
            string tagID_16 = "Channel1.Device1.Status_PLCERROR";
            string tagID_17 = "Channel1.Device1.Status_PLCERROR1";
            string tagID_18 = "Channel1.Device1.Status_PLCERROR2";
            string tagID_19 = "Channel1.Device1.Status_PLCERROR3";
            string tagID_20 = "Channel1.Device1.Status_PLCERROR4";
            string tagID_21 = "Channel1.Device1.Status_PLCERROR5";
            string tagID_22 = "Channel1.Device1.Status_PLCERROR6";
            string tagID_23 = "Channel1.Device1.Status_PLCERROR7";
            string tagID_24 = "Channel1.Device1.Status_PLCERROR8";
            string tagID_25 = "Channel1.Device1.Status_PLCERROR9";
            string tagID_26 = "Channel1.Device1.Report_Trigger";
            string tagID_27 = "Channel1.Device1.Report_D";
            string[] tags;
            tags = new string[tagnumber];
            tags.SetValue(tagID_1, 1);
            tags.SetValue(tagID_2, 2);
            tags.SetValue(tagID_3, 3);
            tags.SetValue(tagID_4, 4);
            tags.SetValue(tagID_5, 5);
            tags.SetValue(tagID_6, 6);
            tags.SetValue(tagID_7, 7);
            tags.SetValue(tagID_8, 8);
            tags.SetValue(tagID_9, 9);
            tags.SetValue(tagID_10,10);
            tags.SetValue(tagID_11,11);
            tags.SetValue(tagID_12,12);
            tags.SetValue(tagID_13, 13);
            tags.SetValue(tagID_14, 14);
            tags.SetValue(tagID_15, 15);
            tags.SetValue(tagID_16, 16);
            tags.SetValue(tagID_17, 17);
            tags.SetValue(tagID_18, 18);
            tags.SetValue(tagID_19, 19);
            tags.SetValue(tagID_20, 20);
            tags.SetValue(tagID_21, 21);
            tags.SetValue(tagID_22, 22);
            tags.SetValue(tagID_23, 23);
            tags.SetValue(tagID_24, 24);
            tags.SetValue(tagID_25, 25);
            tags.SetValue(tagID_26, 26);
            tags.SetValue(tagID_27, 27);
            return tags;
        }
        // Class tạo array đọc ID tags - mặc định không đổi
        public static Int32[] tagID(int tagnumber)
        {
            Int32[] cltarr;
            cltarr = new Int32[tagnumber];
            for (int i = 1; i < tagnumber; i++)
            {
                cltarr.SetValue(i, i);
            }
            return cltarr;
        }
    }
}
