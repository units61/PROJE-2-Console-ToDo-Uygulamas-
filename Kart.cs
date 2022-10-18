namespace TODO
{
    class Kart
    {
       private string Baslik;
        private string Icerik;
       private string AtananKisi;
       private string Buyukluk;
       private string Kolon;

        public string baslik { get => Baslik; set => Baslik = value; }
        public string icerik { get => Icerik; set => Icerik = value; }
        public string atanakisi { get => AtananKisi; set => AtananKisi = value; }
        public string buyukluk { get => Buyukluk; set => Buyukluk = value; }
        public string kolon { get => Kolon; set => Kolon = value; }

         public Kart(string baslik, string ıcerik, string atananKisi, string buyukluk, string kolon)
        {
            Baslik = baslik;
            Icerik = ıcerik;
            AtananKisi = atananKisi;
            Buyukluk = buyukluk;
            Kolon = kolon;
        }

        public Kart(){}
    }
}
