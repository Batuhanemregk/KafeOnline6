﻿namespace KafeOnline6.Data
{
    public class KafeVeri
    {
        public int MasaAdet {  get; set; } = 20;
        public List<Urun> Urunler { get; set; } = new ();
        public List<Siparis> AktifSiparisler { get; set; } = new ();
        public List<Siparis> GecmisSiparisler { get; set; } = new ();

    }
}