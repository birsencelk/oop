using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop.Kapsulleme
{
    class Tasit
    {
        public string marka;
        public string yakitTuru;
        private int hiz;
        public int Hiz
        {
            get { return hiz; }
            set
            {
                if (value <= 200)
                {
                    hiz = value;
                }
                else { Console.WriteLine("bu hizda bir taşıt üretmiyoruz"); }
            }
        }
        public string HizliMi()
        {
            if (Hiz > 150)
                return "Çok Hızlısın";
            else
                return "Hızınız Normal Seviyede";
        }
    }
}
