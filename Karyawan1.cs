using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMMANAJEMENKARYAWAN // namespace
{
    public class Karyawan1 //membuat class karyawan menjadi public sehingga bisa diakses dimana saja diluar program
    {
        private string Nama;  //membuat 3 atribut privat : nama pakai string,id pakai string dan gajipkok pakai double,
        private string ID;    // untuk menyimpan informasi dari class parent Karyawan1.
        private double GajiPokok;

        public string nama  //menjadikan properti nama dengan tipe datanya string menjadi public agar bisa diakses di luar kelas
        {
            get { return Nama; } // return/ngembalikan nilai dari variabel nama
            set{ Nama = value; } // meng set/menetapkan nilai nama dengan value yang diberikan
        }

        public string iD  //menjadikan properti id tipe data string menjadi public agar bisa diakses di luar kelas
        {
            get { return ID; } // return/ngembalikan nilai dari variabel id 
            set { ID = value; } // meng set/menetapkan nilai id dengan value yang diberikan
        }

        public double gajipokok //menjadikan properti gajipokok tipe data double menjadi public agar bisa diakses di luar kelas
        {
            get { return GajiPokok; } // return/ngembalikan nilai dari variabel gajipokok
            set { GajiPokok = value; } // meng set/menetapkan nilai gajipokok dengan value yang diberikan
        }

        public Karyawan1(string Nama, string ID, double GajiPokok) //konstruktor karyawan public dengan 3 parameter nama,id,dan gaji pokok
        {
            this.Nama = Nama; //menetapkan nilai ke variabel instancenya. memakai this untuk membedakan mana yg parameter dan variabel instance
            this.ID = ID;
            this.GajiPokok = GajiPokok;
        }

        public virtual double HitungGaji() //membuat metode baru hitung gaji yang bisa diakses luar kelas.
        {                                  // virtual untuk override kelas turunan nanti dengan tipe data double
            return GajiPokok; //mengembalikan nilai variabel GajiPokok
        }
    }
}
