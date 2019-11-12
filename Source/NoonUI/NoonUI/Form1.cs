using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace NoonUI
{
    public partial class Form1 : Form, IMessageFilter
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

        private HashSet<Control> controlsToMove = new HashSet<Control>();

        static bool eyePointing = false;
        Process process;
        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);

            controlsToMove.Add(this);
            IntPtr wow64Value = IntPtr.Zero;
            Wow64DisableWow64FsRedirection(ref wow64Value);

        }

        //아이트래커 실행
        private void Eyetracker_Click(object sender, EventArgs e)
        {
            eyePointing = !eyePointing;
            if (eyePointing)
            {
                process = Process.Start(@"C:\\Users\Song\Desktop\source\eye-tracking-zoom\eye-tracking-zoom\bin\Debug\eye-tracking-zoom.exe"); //시연시에 바꿔야됨
                Eyetracker.BackColor = Color.LightGray;
            }
            else
            {
                process.Kill();
                Eyetracker.BackColor = Color.Transparent;
            }
        }

        //돋보기 실행
        private void Magnify_Click(object sender, EventArgs e)
        {
            Process[] handler = Process.GetProcessesByName("Magnify");
            if (handler.Length == 0)
            {
                ProcessStartInfo process = new ProcessStartInfo();
                process.FileName = @"Magnify.exe";
                Magnify.BackColor = Color.LightGray;
                Process.Start(process);
            }
            else
            {
                handler[0].Kill();
                Magnify.BackColor = Color.Transparent;
            }
        }

        //내레이터 실행
        private void Narrator_Click(object sender, EventArgs e)
        {
            Process[] handler = Process.GetProcessesByName("Narrator");
            if (handler.Length == 0)
            {
                ProcessStartInfo process = new ProcessStartInfo();
                process.FileName = @"Narrator.exe";
                Narrator.BackColor = Color.LightGray;
                Process.Start(process);
            }
            else
            {
                Narrator.BackColor = Color.Transparent;
                handler[0].Kill();
            }
        }
        
        //화상키보드 실행
        private void Keyboard_Click(object sender, EventArgs e)
        {
            Process[] handler = Process.GetProcessesByName("osk");
            if (handler.Length == 0)
            {
                ProcessStartInfo process = new ProcessStartInfo();
                process.FileName = @"osk.exe";
                Keyboard.BackColor = Color.LightGray;
                Process.Start(process);
            }
            else
            {
                Keyboard.BackColor = Color.Transparent;
                handler[0].Kill();
            }
        }

        //항상위 실행
        private void AlwaysTop_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
            if (TopMost)
            { AlwaysTop.BackColor = Color.LightGray; }
            else
            { AlwaysTop.BackColor = Color.Transparent; }
        }

        //닫기버튼
        private void Closebt_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Magnify").Length > 0)
            { Magnify.BackColor = Color.LightGray; }
            else { Magnify.BackColor = Color.Transparent; }

            if (Process.GetProcessesByName("Narrator").Length > 0)
            { Narrator.BackColor = Color.LightGray; }
            else { Narrator.BackColor = Color.Transparent; }

            if (Process.GetProcessesByName("osk").Length > 0)
            { Keyboard.BackColor = Color.LightGray; }
            else { Keyboard.BackColor = Color.Transparent; }
        }

        public bool PreFilterMessage(ref System.Windows.Forms.Message message)
        {
            if (message.Msg == WM_LBUTTONDOWN &&
                 controlsToMove.Contains(Control.FromHandle(message.HWnd)))
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return true;
            }
            return false;
        }
    }
}
