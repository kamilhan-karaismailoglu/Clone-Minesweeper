using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mayin_tarlasi
{
    public class Tarla
    {
        Size Ebat;
        List<Mayin> Mayinlar;
        int DoluMayinSayisi;
        Random rnd = new Random();
        public Size Buyukluk { get { return Ebat; } }

        public Tarla(Size GelenEbat, int GelenDoluMayinSayisi)
        {
            Ebat = GelenEbat;
            Mayinlar = new List<Mayin>();
            DoluMayinSayisi = GelenDoluMayinSayisi;

            for (int x = 0; x < Ebat.Width; x = x + 20)
            {
                for (int y = 0; y < Ebat.Height; y = y + 20)
                {
                    Mayin YeniMayin = new Mayin(new Point(x, y));
                    AddMayin(YeniMayin);
                }
            }
            MayinlariDoldur();
        }
        public void AddMayin(Mayin GelenMayin)
        {
            Mayinlar.Add(GelenMayin);
        }
        private void MayinlariDoldur()
        {
            int sayi = 0;
            while (sayi < DoluMayinSayisi)
            {
                int i = rnd.Next(0,Mayinlar.Count);
                Mayin item = Mayinlar[i];
                if (item.DoluMu == false)
                {
                    item.DoluMu = true;
                    sayi++;
                }
            }
        }
        public Mayin GetMayinWithLoc(Point konum)
        {
            foreach (Mayin mayin in Mayinlar)
            {
                if (mayin.KonumBelirle == konum)
                {
                    return mayin;
                }
            }
            return new Mayin(new Point(-100,-100));
        }
        public List<Mayin> GetAllMayin { get { return Mayinlar; } }

    }
}
