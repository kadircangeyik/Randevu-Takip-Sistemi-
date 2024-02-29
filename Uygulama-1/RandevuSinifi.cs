using System;

internal class Randevu
{
   // Randevunun özelliklerini temsil eder.
    int id;
    string ad;
    string telefon;
    DateTime tarih;
    bool sigorta;
    string poliklinik;

    public int Id { get => id; set => id = value; }
    public string Ad { get => ad; set => ad = value; }
    public string Telefon { get => telefon; set => telefon = value; }
    public DateTime Tarih { get => tarih; set => tarih = value; }
    public bool Sigorta { get => sigorta; set => sigorta = value; }
    public string Poliklinik { get => poliklinik; set => poliklinik = value; }

    public Randevu(int id, string ad, string telefon, DateTime tarih, bool sigorta, string poliklinik)
    {
        this.id = id;
        this.ad = ad;
        this.telefon = telefon;
        this.tarih = tarih;
        this.sigorta = sigorta;
        this.poliklinik = poliklinik;
    }
}
