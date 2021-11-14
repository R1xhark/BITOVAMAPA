using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BITOVAMAPA
{
    
        // Deklarace třídy, jejíž instance dovedou pracovat s bitovými mapami.
        public class BitovaMapa
        {
            // Definice soukromých datových členů třídy.
            private string cestaKBitmape;
            private Bitmap bitmapa;
            // Definice veřejného instančního bezparametrického konstruktoru.
            public BitovaMapa()
            {
            cestaKBitmape = Environment.CurrentDirectory + @"C:\Users\Richard\Downloads\jeri.bmp";
                NacistBitovouMapu(cestaKBitmape);
            }
            // Definice veřejné instanční parametrické metody, která provede
            // načtení bitové mapy z fyzického souboru. 
            
 public void NacistBitovouMapu(string cesta)
            {
                cestaKBitmape = cesta;
                bitmapa = new Bitmap(cesta);
            }
            // Definice veřejné instanční metody, která zobrazí bitovou mapu
            // na formuláři.
            public void ZobrazitBitovouMapu()
            {
                Form formular = Form.ActiveForm;
                Graphics grafickyObjekt = formular.CreateGraphics();
                grafickyObjekt.DrawImage(bitmapa, 10, 10, 200, 150);
                grafickyObjekt.Dispose();
            }
        }
    }


