using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap_Sinif_list_sistem
{
    internal class Kitap
    {
        int id;
        string kitapAdi;
        string yazar;
        string sayfaSayisi;
        string tur;
        bool cilt;
        DateTime basimTarihi;

        public int Id { get => id; set => id = value; }
        public string KitapAdi { get => kitapAdi; set => kitapAdi = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public string SayfaSayisi { get => sayfaSayisi; set => sayfaSayisi = value; }
        public string Tur { get => tur; set => tur = value; }
        public bool Cilt { get => cilt; set => cilt = value; }
        public DateTime BasimTarihi { get => basimTarihi; set => basimTarihi = value; }

        public Kitap(int id, string kitapAdi, string yazar, string sayfaSayisi, string tur, bool cilt, DateTime basimTarihi)
        {
            this.id = id;
            this.kitapAdi = kitapAdi;
            this.yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
            this.tur = tur;
            this.cilt = cilt;
            this.basimTarihi = basimTarihi;
        }
    }
}
