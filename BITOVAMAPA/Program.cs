using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITOVAMAPA
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Zjištění velikosti pracovní sady běžícího procesu pomocí
            // vlastnosti WorkingSet třídy Environment.
            long pracovniSada = System.Environment.WorkingSet;
            Console.WriteLine("Velikost pracovní sady pro tento proces je " +
            (pracovniSada / (1024 * 1024)) + " MB.");
        }
    }
}
