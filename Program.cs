using SISTEMMANAJEMENKARYAWAN;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input jenis karyawan ketik angka saja(1tetap/2magang/3kontrak): ");
        int input = int.Parse(Console.ReadLine());

        Console.Write("input nama: ");
        string nama = Console.ReadLine();

        Console.Write("input ID: ");
        string id = Console.ReadLine();

        Console.Write("input gaji pokok: ");
        double gajipokok = double.Parse(Console.ReadLine());

        if (input == 1)
        {
            KaryawanTetap karyawanTetap = new KaryawanTetap(nama, id, gajipokok);
            double hasil = karyawanTetap.HitungGaji();
            Console.WriteLine($"gaji akhirmu: {hasil}");
        }
        else if (input == 2)
        {
            KaryawanKontrak karyawanKontrak = new KaryawanKontrak(nama, id, gajipokok);
            double hasil = karyawanKontrak.HitungGaji();
            Console.WriteLine($"gaji akhirmu: {hasil}");
        }
        else if (input == 3)
        {
            KaryawanMagang karyawanMagang = new KaryawanMagang(nama, id, gajipokok);
            double hasil = karyawanMagang.HitungGaji();
            Console.WriteLine($"gaji akhirmu: {hasil}");
        }

        else
        {
            Console.WriteLine("inputan salah.");
        }
    }
}