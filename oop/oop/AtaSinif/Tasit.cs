using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop.AtaSinif
{
    class Tasit
    {
        public string marka;
        public int hiz;
        public virtual string HizliMi()
        {
            if (hiz > 150)
                return "Çok Hızlısın";
            else
                return "Hızınız Normal Seviyede";
        }
    }
}
