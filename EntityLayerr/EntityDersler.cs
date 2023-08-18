using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDersler
    {
        private int DersID;
        private int DersAdi;
        private int DersMinKontenjan;
        private int DersMaxKontenjan;

        public int DERSID { get => DersID; set => DersID = value; }
        public int DERSAD { get => DersAdi; set => DersAdi = value; }
        public int DERSMINKONTENJAN { get => DersMinKontenjan; set => DersMinKontenjan = value; }
        public int DERSMAXKONTENJAN { get => DersMaxKontenjan; set => DersMaxKontenjan = value; }
    }
}
