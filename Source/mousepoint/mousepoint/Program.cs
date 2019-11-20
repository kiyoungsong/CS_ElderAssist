using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;

namespace mousepoint
{
    class Program
    {
        [DllImport("user32")]
        public static extern Int32 GetCursorPos(out POINT pt);
        public struct POINT
        {
            public Int32 x;
            public Int32 y;
        }

        static void Main(string[] args)
        {
            POINT pt;

            string savePath = @"C:\text.txt";
            string txt;
            
            int i = 0;
            while(i <  100000)
            {
                GetCursorPos(out pt);
                txt = $"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}, CursorX: {pt.x}, CursorY: {pt.y}\n";
                Console.WriteLine($"CursorX: {pt.x}, CursorY: {pt.y}");
                //File.WriteAllText(savePath, txt, Encoding.Default);
                File.AppendAllText(savePath, txt);
                i++;
            }

        }
    }

} 

