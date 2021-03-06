﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Moneda1
{
    public class CompareImgs
    {
        /*
         * Compare images
        */


        public static double Compare(Bitmap img1, Bitmap img2)
        {
            List<bool> iHash1 = GetHash(img1);
            List<bool> iHash2 = GetHash(img2);

            //determine the number of equal pixel (x of 256)
            double equalElements = iHash1.Zip(iHash2, (i, j) => i == j).Count(eq => eq);

            return Math.Round(equalElements / 256, 2);
        }

        public static List<bool> GetHash(Bitmap bmpSource)
        {
            List<bool> lResult = new List<bool>();
            //create new image with 16x16 pixel
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (int j = 0; j < bmpMin.Height; j++)
            {
                for (int i = 0; i < bmpMin.Width; i++)
                {
                    //reduce colors to true / false                
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }
            return lResult;
        }

    }
}
