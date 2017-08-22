using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.AtaSinif;
using oop.Tasitlar;

namespace oop
{
        class Program
    {
        static void Main(string[] args)
        {
            //Kapsülleme Dersinde Anlatılanlar
            //Kapsulleme.Tasit tstHonda = new Kapsulleme.Tasit();
            //tstHonda.Hiz = 160;
            //Console.WriteLine(tstHonda.HizliMi());
            // kalıtım Yapısı

            Bisiklet bisiklet = new Bisiklet();
            bisiklet.hiz = 10;
            bisiklet.marka = "bianchi";
            bisiklet.kacTekerlekli = (int)KacTekerlekli.ikiTekerlekli;
            bisiklet.kacTekerlekli2 = KacTekerlekli.dortTekerlekli;
            Console.WriteLine("bisiklet : " + bisiklet.HizliMi());

            Araba arb = new Araba();
            arb.hiz = 250;
            arb.marka = "renault";
            arb.plakaKodu = "44 ea 444";
            Console.WriteLine("araba: " + arb.HizliMi());

            // kalıtımın intarface yapısı
            //AtaSinif.Intarface.Tasit tst = new AtaSinif.Intarface.Tasit();
            //tst.HizliMi();

            Console.ReadKey();
        }
    }
}
