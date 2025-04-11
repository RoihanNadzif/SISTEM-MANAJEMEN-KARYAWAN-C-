using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN
{
    class KaryawanKontrak : Karyawan1 //subclass dari kelas karyawan
    {
        public KaryawanKontrak(string nama, string iD, double gajipokok) : base(nama, iD, gajipokok)
        { } //construktor publik dari karyawankontrak dengan 3 parameter : nama,iD,gajipokok kemudian menggunakan base,
        private double PKontrak = 200000; // memanggil kontruktor dari superclassnya dengan 3 parameternya ke konstruktor tersebut
        //variable tipe data double PKontrak yang nilainya
        public override double HitungGaji() // metod yang meng overide metod hitunggaji dari kelas karyawan
        {
            return gajipokok + PKontrak; //menjumlahkan gajipokok dengan pkonrak dan nanti di return
        }
    }
}
