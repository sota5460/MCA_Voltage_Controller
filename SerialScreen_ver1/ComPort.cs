using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management;

namespace SerialScreen_ver1
{
    public static class ComPort
    {
        public static Queue<string> List()
        {
            var p =
            (new ManagementClass("Win32_SerialPort")).GetInstances()
                    .OfType<ManagementObject>()
                    .Select(x => x.GetPropertyValue("Caption").ToString())
                    .Where(x => x.Contains("ST")); //　コムポート名に含む文字列を入れる。

            //ManagementClass device = new ManagementClass("Win32_SerialPort");

            //foreach (ManagementObject port in device.GetInstances())
            //{
            //    Console.WriteLine("[device ] {0}", (string)port.GetPropertyValue("DeviceID"));
            //    Console.WriteLine("[caption] {0}", (string)port.GetPropertyValue("Caption"));
            //}

            return new Queue<string>(p);
        }

        // シリアル通信用デバイス名から COM ポート番号を取得
        //		戻り値： "COMxxx", xxx は番号
        public static string GetNumber(string str)
        {
            return str.Substring(str.IndexOf("(COM") + 1).TrimEnd(')');
        }
    }
}
