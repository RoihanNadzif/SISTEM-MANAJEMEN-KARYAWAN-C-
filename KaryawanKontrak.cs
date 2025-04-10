using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN
{
    class KaryawanKontrak : Karyawan1
    {
        public KaryawanKontrak(string nama, string iD, double gajipokok) : base(nama, iD, gajipokok)
        { }
        private double PKontrak = 200000;

        public override double HitungGaji()
        {
            return gajipokok + PKontrak;
        }
    }
}
