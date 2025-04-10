using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN
{
    class KaryawanTetap : Karyawan1
    {
        private double BTetap = 500000;
        public KaryawanTetap(string Nama, string ID, double GajiPokok) : base(Nama, ID, GajiPokok){}

        public override double HitungGaji()
        {
            return gajipokok + BTetap;
        }
    }
}
