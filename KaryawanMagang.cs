using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN
{
    class KaryawanMagang : Karyawan1
    {
        public KaryawanMagang(string nama, string iD, double gajipokok) : base(nama, iD, gajipokok)
        {}

        public override double HitungGaji()
        {
            return gajipokok;
        }
    }
}
