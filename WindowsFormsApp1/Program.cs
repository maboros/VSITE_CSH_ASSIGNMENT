using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Napraviti GUI program koji će imati polje za unos teksta, 
 omogućiti učitavanje iz i pohranjivanje u datoteku 
 te dvije naredbe u izborniku (menu), nazovimo ih „Sva velika“ i „Prema pravopisu“. 
 Odabirom naredbe „Sva velika“ sva označena (selektirana) slova u tekstu se trebaju promijeniti u velika (capital), 
 a odabirom naredbe „Prema pravopisu“ slova se moraju prebaciti u mala, 
 osim slova iza znakova interpunkcije (točka, zarez, uskličnik), 
 koja se moraju prebaciti prema pravopisnim pravilima. 
 Voditi računa o pravilima pisanja velikih slova „dž“, „lj“, „nj“!
     */

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
