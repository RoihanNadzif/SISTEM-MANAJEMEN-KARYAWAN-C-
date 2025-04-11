using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN
{
    class KaryawanTetap : Karyawan1 //subclass dari kelas karyawan
    {
        private double BTetap = 500000; //variable tipe data double BKontrak yang nilainya ditentukan oleh dalam kelas dan hanya bisa diakses di kelas tersebut.
        public KaryawanTetap(string Nama, string ID, double GajiPokok) : base(Nama, ID, GajiPokok) //construktor publik dari karyawankontrak dengan 3 parameter : nama,iD,gajipokok kemudian menggunakan base,
        {} // memanggil kontruktor dari superclassnya dengan 3 parameternya ke konstruktor tersebut


        public override double HitungGaji() // metod yang meng overide metod hitunggaji dari kelas karyawan
        {
            return gajipokok + BTetap;  //menjumlahkan gajipokok dengan BTetap dan nanti di return

        }
    }
}
