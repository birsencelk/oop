using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.AtaSinif;

namespace oop.Tasitlar
{
    // childsınıf : atasınıf bu olay kalıtımdır
    class Bisiklet : Tasit
    {
        public int kacTekerlekli;
        public KacTekerlekli kacTekerlekli2;
        public override string HizliMi()
        {
            if (hiz > 15)
                return "bisiklet çok hızlı";
            else
                return "bisiklet normal hızda";
        }
    }
}
