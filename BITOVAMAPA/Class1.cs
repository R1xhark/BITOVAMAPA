using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BITOVAMAPA
{
    
        
        public class BitovaMapa
        {
            // Definice soukromých datových členů třídy.
            private string cestaKBitmape;
            private Bitmap bitmapa;
            
            public BitovaMapa()
            {
            cestaKBitmape = Environment.CurrentDirectory + @"C:\Users\Richard\Downloads\jeri.bmp";
                NacistBitovouMapu(cestaKBitmape);
            }
         
            
 public void NacistBitovouMapu(string cesta)
            {
                cestaKBitmape = cesta;
                bitmapa = new Bitmap(cesta);
            }
            
            public void ZobrazitBitovouMapu()
            {
                Form formular = Form.ActiveForm;
                Graphics grafickyObjekt = formular.CreateGraphics();
                grafickyObjekt.DrawImage(bitmapa, 10, 10, 200, 150);
                grafickyObjekt.Dispose();
            }
        }
    }


