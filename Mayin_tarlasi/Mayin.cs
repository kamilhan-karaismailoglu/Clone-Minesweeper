using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mayin_tarlasi
{
    public class Mayin
    {
        Point konum;
        bool dolu;
        bool kontrol;

        public Point KonumBelirle { get { return konum; } }
        public bool DoluMu { get { return dolu; } set { dolu = value; } }
        public bool BakıldıMı { get { return kontrol; } set { kontrol = value; } }

        public Mayin(Point GelenKonum)
        {
            dolu = false;
            konum = GelenKonum;
        }
    }
}
