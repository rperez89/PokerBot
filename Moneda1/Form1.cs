using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

using HoldemHand;

namespace Moneda1
{
    public partial class Form1 : Form
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }

        Process[] processlist;
        int procId;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get Windows Current Processes
            processlist = Process.GetProcesses();

            int i = 0;
            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    comboVentanas.Items.Insert(i, process.MainWindowTitle);
                    i++;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // procId = Int32.Parse(textBox1.Text);
            Camera.ClickClick(procId, "shots/screenshot.tiff");
            //Camera.ClickClick(2559064, "shots/screenshot.tiff");

            //get players data
            //processImg.startPoint();

            //terminate program
           // System.Windows.Forms.Application.Exit();
        }

        private void comboVentanas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set the current processId
            string procName = comboVentanas.Text;
            System.Console.WriteLine(procName);

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    if (process.MainWindowTitle.Trim().Equals(procName))
                    {
                        procId = process.Id;
                        lblProcId.Text = "ProcID: " + procId.ToString();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Comparar dos imagenes
            int pnumero = processImg.getDealer(new Bitmap("shots/screenshot.png"));
            System.Console.WriteLine("player: {0}", pnumero.ToString());
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            //Comparar dos imagenes
            string text = OCR.TestOCR();
            Console.WriteLine("Testing: \r\n{0}", text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IsMyTurn_Click(object sender, EventArgs e)
        {
            double myTurn;
            //Bitmap bit = new Bitmap("shots/screenshot.tiff");
            myTurn = processImg.isMyTurn(procId);
            
            string targetPath = @"C:\Users\Rodrigo\Documents\psv1\Moneda1\bin\Debug\shots";
            string sourcePath = @"C:\Users\Rodrigo\AppData\Local\PokerStars";
            string fileName = "PokerStars.log.0";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            System.IO.File.Copy(sourceFile, destFile, true);
            string text = System.IO.File.ReadAllText(@"C:\Users\Rodrigo\Documents\psv1\Moneda1\bin\Debug\shots\PokerStars.log.0");
                      

            System.Console.WriteLine("Is my turn: " + myTurn.ToString());

        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            string targetPath = @"C:\Users\Rodrigo\Documents\psv1\Moneda1\bin\Debug\shots";
            string sourcePath = @"C:\Users\Rodrigo\AppData\Local\PokerStars";
            string fileName = "PokerStars.log.0";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);
            string pocket = "4s Ks";
            string board = "";
            int noOponents = 0;
            double duration = 1.25;
            

           // System.IO.File.Copy(sourceFile, destFile, true);
            

            string text = System.IO.File.ReadAllText(@"C:\Users\Rodrigo\Documents\psv1\Moneda1\bin\Debug\shots\PokerStars.log.0");
            int strLen = text.Length;

            int index = text.LastIndexOf("dealerPos=");

            string text2 = text.Substring(index);

            index = text2.LastIndexOf("UpdateMyCard 0:");

            index = index + 15;
            string card1 = text2.Substring(index,4);
            index = text2.LastIndexOf("UpdateMyCard 1:");
            index = index + 15;
            string card2 = text2.Substring(index,4);

            System.Console.WriteLine("Carta 1 :" + card1.ToString());
            System.Console.WriteLine("Carta 2 :" + card2.ToString());

            double strenght = Hand.HandStrength(pocket, board, 1, duration);
            strenght = strenght * 100;
            System.Console.WriteLine("Strenght: " + strenght.ToString());


            Form1.POINT p = new Form1.POINT();
            p.x = Convert.ToInt16(1185);
            p.y = Convert.ToInt16(720);

            Form1.ClientToScreen(this.Handle, ref p);
            Form1.SetCursorPos(p.x, p.y);

            Form1.mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 1185, 720, 0, 0);

        }
    }
}
