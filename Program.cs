using SISTEMMANAJEMENKARYAWAN;

internal class Program
{
    static void Main(string[] args) // metod utama dari program
    {
        Console.WriteLine("input jenis karyawan ketik angka saja(1tetap/2magang/3kontrak): "); //menampilkan kalimat ke konsol untuk meminta input jenis karyawan ketik....
        int input = int.Parse(Console.ReadLine()); //membaca inputan pengguna,mengonversi string ke int menggunakan parse. Kemudian disimpan dalam variabel input.

        Console.Write("input nama: "); //menampilkan kalimat ke konsol untuk meminta input nama:
        string nama = Console.ReadLine(); //membaca input nama dari user kemudian disimpan di variabel 'nama'

        Console.Write("input ID: "); //menampilkan kalimat ke konsol untuk meminta input id:
        string id = Console.ReadLine(); //membaca input id dari user kemudian disimpan di variabel 'id'

        Console.Write("input gaji pokok: "); //menampilkan kalimat ke konsol untuk meminta input gajipokok:
        double gajipokok = double.Parse(Console.ReadLine()); //membaca input gaji dari user kemudian dibuah ke tipe data double lalu disimpan di variabel 'gajipokok'
        
        if (input == 1) //cek if apakah user menginput 1
        {
            KaryawanTetap karyawanTetap = new KaryawanTetap(nama, id, gajipokok); // membuat objek baru karyawan tetap dengan 3 parameter utama : nama,id, dan gajipokok.
            double hasil = karyawanTetap.HitungGaji(); // memanggil metod hitunggaji pada objek baru untuk menghitung hasil dan disimpan dalam variabel hasil
            Console.WriteLine($"gaji akhirmu: {hasil}"); // menampilkan pesan ke konsol hasil perhitungan
        }
        else if (input == 2) //cek if apakah user menginput 2
        {
            KaryawanKontrak karyawanKontrak = new KaryawanKontrak(nama, id, gajipokok); // membuat objek baru karyawan kontrak dengan 3 parameter utama : nama,id, dan gajipokok.
            double hasil = karyawanKontrak.HitungGaji(); // memanggil metod hitunggaji pada objek baru untuk menghitung hasil dan disimpan dalam variabel hasil
            Console.WriteLine($"gaji akhirmu: {hasil}"); // menampilkan pesan ke konsol hasil perhitungan
        }
        else if (input == 3) //cek if apakah user menginput 3
        {
            KaryawanMagang karyawanMagang = new KaryawanMagang(nama, id, gajipokok); // membuat objek baru karyawan magang dengan 3 parameter utama : nama,id, dan gajipokok.
            double hasil = karyawanMagang.HitungGaji(); // memanggil metod hitunggaji pada objek baru untuk menghitung hasil dan disimpan dalam variabel hasil
            Console.WriteLine($"gaji akhirmu: {hasil}"); // menampilkan pesan ke konsol hasil perhitungan
        }

        else // jika user memilih selain yang sudah ditentukan
        {
            Console.WriteLine("inputan salah."); //menampilkan pesan ke konsol inputan salah
        }
    }
}
