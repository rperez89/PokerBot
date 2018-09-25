using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing;
using System.Diagnostics;

namespace Moneda1
{
    public class Camera
    {
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        public static void ClickClick(int pId, string screenshotPath)
        {
            var bitmap = CaptureApplicationScreenshot(pId);
            //Bitmap b = new Bitmap(1850, 782, PixelFormat.Format64bppArgb);

            //Graphics g = Graphics.FromImage(b);
            //g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            //g.DrawImage(bitmap, 0, 0, 1850, 782);

            bitmap.Save(screenshotPath, ImageFormat.Tiff);
            
           
        }

        public static Bitmap CaptureApplicationScreenshot(int pId)
        {
            var proc = Process.GetProcessById(pId);
            //var proc = Process.GetProcessesByName("PokerStarsChatClass");
            //var proc = Process.GetProcessById(pId);
            var hWnd = proc.MainWindowHandle;


            //var intHand = 725572;
            //IntPtr intP = (IntPtr) intHand;
            //window.Focus();

            Rect rc;
             GetWindowRect(hWnd, out rc);
            //GetWindowRect(intP, out rc); 


            Bitmap bmp = new Bitmap(rc.Width, rc.Height, PixelFormat.Format64bppArgb);
            //Bitmap bmp = new Bitmap(1850, 782, PixelFormat.Format64bppArgb);
            Graphics gfxBmp = Graphics.FromImage(bmp);
          

            IntPtr hdcBitmap = gfxBmp.GetHdc();

            PrintWindow(hWnd, hdcBitmap, 0);
            gfxBmp.ReleaseHdc(hdcBitmap);
            gfxBmp.Dispose();       

            return bmp;
        }
    }
}
