using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Tobii.Interaction;

namespace CapstoneMagnifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int gazePointX;
            int gazePointY;
            int gazeCursorX = Cursor.Position.X;
            int gazeCursorY = Cursor.Position.Y;
            int oldscreenW = 50;
            int oldscreenH = 50;
            double magnification = 2.0;
            System.Drawing.Size size = new System.Drawing.Size(oldscreenW, oldscreenH);
            Bitmap bitmap = new Bitmap(size.Width,size.Height);

            bool onOff;

            Graphics graphics = Graphics.FromImage(bitmap);
            

            int newScreenW = (int)(oldscreenW * magnification);
            int newScreenH = (int)(oldscreenH * magnification);

            Bitmap zoomin = new Bitmap(newScreenW, newScreenH);

            

            Console.WriteLine($"커서X{gazeCursorX},커서Y{gazeCursorY}");
            Console.WriteLine($"스크린X{size}");

           
        }
        
        public void CopyFromScreen()
        {

        }

        public void MouseMove()
        {

        }

        public int ZoomIn(int magnification)
        {

            return magnification;
        }

        public int ZoomOut(int magnification)
        {

            return magnification;
        }

        public Boolean OnoffSwitch(bool onOff)
        {


            return onOff;
        }

        public static void Tick()
        {

        }

        public double Timer(double time)
        {
            return time;
        }

        public void AutoZoomIn()
        {

        }
    }

}
