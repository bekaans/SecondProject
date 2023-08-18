using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruFormu
    {
        private int BasvuruID;
        private int OgrenciID;
        private int DersID;

        public int BASVURUID { get => BasvuruID; set => BasvuruID = value; }
        public int OGRENCIID { get => OgrenciID; set => OgrenciID = value; }
        public int DERSID { get => DersID; set => DersID = value; }
    }
}
