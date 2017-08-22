using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.AtaSinif;

namespace oop.Tasitlar
{
    // çocuksınıf : atasınıf bu olay kalıtımdır
    class Araba : Tasit
    {
        public string plakaKodu;
        public override string HizliMi()
        {
            if (hiz > 200)
                return "arabanız çok hızlı";
            else
                return "arabanız normal hızda";
        }
    }
}
