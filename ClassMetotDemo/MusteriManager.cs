using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteris = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Ad + " " + musteri.Soyad);
            musteris.Add(musteri);
        }
        public void Sil(int id)
        {

            musteris.Remove(musteris.FirstOrDefault(x => x.Id == id));
            Console.WriteLine(id + " id li müşteri silindi.");

        }

        public void Listele()
        {
            foreach (Musteri musteriler in musteris)
            {
                Console.WriteLine(musteriler.Id + " " + musteriler.Ad + " " + musteriler.Soyad);

            }
        }
    }
}
