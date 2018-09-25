using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace Moneda1
{
    class OCR
    {
        public static string TestOCR()
        {
            var testImagePath = "C:/Users/Rodrigo/Documents/psv1/Moneda1/bin/Debug/shots/screenshot.tiff";

            var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.TesseractOnly);
                
            var img = Pix.LoadFromFile(testImagePath);                        
            
            var page = engine.Process(img);
            page.AnalyseLayout();

            page.AnalyseLayout();
            var text2 = page.GetHOCRText(1);

            var text = page.GetText();

            return text;
        }
    }
}
