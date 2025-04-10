using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN
{
    public class Karyawan1
    {
        private string Nama;
        private string ID;
        private double GajiPokok;

        public string nama
        {
            get { return Nama; }
            set{ Nama = value; }
        }

        public string iD
        {
            get { return ID; }
            set { ID = value; }
        }

        public double gajipokok
        {
            get { return GajiPokok; }
            set { GajiPokok = value; }
        }

        public Karyawan1(string Nama, string ID, double GajiPokok)
        {
            this.Nama = Nama;
            this.ID = ID;
            this.GajiPokok = GajiPokok;
        }

        public virtual double HitungGaji()
        {
            return GajiPokok;
        }
    }
}
