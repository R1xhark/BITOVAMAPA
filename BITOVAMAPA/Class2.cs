using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BITOVAMAPA
{
    
        public partial class Form1 : Form
        {
        public Form1()
        {
            InitializeComponent();
        }

            private void btnZobrazitBitmapu_Click(object sender, EventArgs e)
            {
                // Založení nové instance třídy BitovaMapa.
                BitovaMapa bitmapa = new BitovaMapa();
                // Zobrazení bitové mapy na ploše formuláře.
                bitmapa.ZobrazitBitovouMapu();
            }

    }
    }

