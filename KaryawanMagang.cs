using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN
{
    class KaryawanMagang : Karyawan1  //subclass dari kelas karyawan
    {
        public KaryawanMagang(string nama, string iD, double gajipokok) : base(nama, iD, gajipokok) 
        {} //construktor publik dari karyawankontrak dengan 3 parameter : nama,iD,gajipokok kemudian menggunakan base,
        // memanggil kontruktor dari superclassnya dengan 3 parameternya ke konstruktor tersebut
        public override double HitungGaji() // metod yang meng overide metod hitunggaji dari kelas karyawan
        {
            return gajipokok; //me return gajipokok karena tidak ada kondisi penjumlahan/pengurangannya
        }
    }
}
