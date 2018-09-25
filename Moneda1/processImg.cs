using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Moneda1
{
    public class processImg
    {
        

        public static void startPoint()
        {
            //get table image
            Bitmap original = new Bitmap(@"shots/screenshot.tiff");

            //players portions
            //getP0nameAndBalace(1, original);
            //getP0nameAndBalace(2, original);
            //getP0nameAndBalace(3, original);
            //getP0nameAndBalace(4, original);
            //getP0nameAndBalace(5, original);
            //getP0nameAndBalace(6, original);
        }

        public static void getP0nameAndBalace(int playerNum, Bitmap mainImage)
        {
            /*
             * Get PlayerX img Portion
             * 
            */

            switch (playerNum)
            {
                case 1:
                    Rectangle srcRect1 = new Rectangle(328, 76, 107, 45);
                    Bitmap cropped1 = (Bitmap)mainImage.Clone(srcRect1, mainImage.PixelFormat);
                    cropped1.Save("shots/p1.png", ImageFormat.Png);
                    break;
                case 2:
                    Rectangle srcRect2 = new Rectangle(703, 116, 94, 43);
                    Bitmap cropped2 = (Bitmap)mainImage.Clone(srcRect2, mainImage.PixelFormat);
                    cropped2.Save("shots/p2.png", ImageFormat.Png);
                    break;
                case 3:
                    Rectangle srcRect3 = new Rectangle(700, 305, 93, 40);
                    Bitmap cropped3 = (Bitmap)mainImage.Clone(srcRect3, mainImage.PixelFormat);
                    cropped3.Save("shots/p3.png", ImageFormat.Png);
                    break;
                case 4:
                    Rectangle srcRect4 = new Rectangle(378, 412, 94, 43);
                    Bitmap cropped4 = (Bitmap)mainImage.Clone(srcRect4, mainImage.PixelFormat);
                    cropped4.Save("shots/p4.png", ImageFormat.Png);
                    break;
                case 5:
                    Rectangle srcRect5 = new Rectangle(37, 316, 100, 42);
                    Bitmap cropped5 = (Bitmap)mainImage.Clone(srcRect5, mainImage.PixelFormat);
                    cropped5.Save("shots/p5.png", ImageFormat.Png);
                    break;
                case 6:
                    Rectangle srcRect6 = new Rectangle(34, 142, 108, 45);
                    Bitmap cropped6 = (Bitmap)mainImage.Clone(srcRect6, mainImage.PixelFormat);
                    cropped6.Save("shots/p6.png", ImageFormat.Png);
                    break;
                default:
                    //no default
                    Rectangle srcRect0 = new Rectangle(1, 1, 1, 1);
                    break;
            }
        }

        public static double isMyTurn(int pId)
        {

            Bitmap table = Camera.CaptureApplicationScreenshot(pId);
            Bitmap IsMyTurnSample = new Bitmap("samples/IsMyTurn.png");


            Bitmap checkImg;
            Rectangle checkRect;
            int x, y;
            //int xLength = 183;
            //int yLength = 27;
            int xLength = 100;
            int yLength = 24;

            x = 640;
            y = 486;

            checkRect = new Rectangle(x, y, xLength, yLength);
            checkImg = (Bitmap)table.Clone(checkRect, table.PixelFormat);

            checkImg.Save("shots/IsMyTurn.png", ImageFormat.Png);
           
            //compare images
            double result = CompareImgs.Compare(IsMyTurnSample, checkImg);

            return result;
           
        }

        public static int getDealer(Bitmap table)
        {
            /*
             * Return the Dealer Player #
            */

            //get dealer coin sample
            Bitmap dealerCoinSample = new Bitmap("samples/DealerCoin.png");

            //check players one by one to save time (when we found one...exit) 
            //   --- Estoy midiendo desde un pixel oscuro q hay en la punta superior de la pica, hacia la derecha

            Bitmap checkImg;
            Rectangle checkRect;
            int x, y;
            int xLength = 9;
            int yLength = 16;

            for (int i=1; i<7; i++)
            {   
                switch (i)
                {
                    case 1:
                        x = 345;
                        y = 140;
                        break;
                    case 2:
                        x = 631;
                        y = 198;
                        break;

                    case 3:
                        x = 597;
                        y = 325;
                        break;
                        
                    case 4:
                        x = 472;
                        y = 361;
                        break;

                    case 5:
                        x = 211;
                        y = 325;
                        break;

                    case 6:
                        x = 186;
                        y = 193;
                        break;

                    default:
                        x = 0;
                        y = 0;
                        break;
                }   

                checkRect = new Rectangle(x, y, xLength, yLength);
                checkImg = (Bitmap)table.Clone(checkRect, table.PixelFormat);

                //compare images
                double result = CompareImgs.Compare(dealerCoinSample, checkImg);

                if (result==1)
                {
                    return i;
                }
            }

            //can't found the dealer.
            return 0;
        }
    }
}
