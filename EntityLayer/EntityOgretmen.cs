using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int OgretmenId;
        private string OgretmenAd;
        private int OgretmenBrans;

        public int OGRETMENID { get => OgretmenId; set => OgretmenId = value; }
        public string OGRETMENAD { get => OgretmenAd; set => OgretmenAd = value; }
        public int OGRETMENBRANS { get => OgretmenBrans; set => OgretmenBrans = value; }
    }
}
