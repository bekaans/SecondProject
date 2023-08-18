namespace EntityLayer
{
    public class EntityOgrenci
    {

        private int id;
        private string ad;
        private string soyad;
        private string numara;
        private string fotograf;
        private string sifre;

        public int ID { get => id; set => id = value; }
        public string AD { get => ad; set => ad = value; }
        public string SOYAD { get => soyad; set => soyad = value; }
        public string NUMARA { get => numara; set => numara = value; }
        public string FOTOGRAF { get => fotograf; set => fotograf = value; }
        public string SIFRE { get => sifre; set => sifre = value; }
    }
}