using System;

namespace ProjectRumahSakit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dokter dokter = new Dokter("Dr. Andi", 35, "Penyakit Dalam");
            Perawat perawat = new Perawat("Siti", 28, "Perawatan Umum");
            Pasien pasien = new Pasien("Budi", 30, "Demam");
            PasienAnak pasienAnak = new PasienAnak("Alya", 7, "Batuk");
            PasienDewasa pasienDewasa = new PasienDewasa("Rina", 42, "Sakit kepala");

            RumahSakit rumahSakit = new RumahSakit();
            rumahSakit.TambahOrang(dokter);
            rumahSakit.TambahOrang(perawat);
            rumahSakit.TambahOrang(pasien);
            rumahSakit.TambahOrang(pasienAnak);
            rumahSakit.TambahOrang(pasienDewasa);

            rumahSakit.DaftarOrang();

            Console.WriteLine("\n DEMONSTRASI POLYMORPHISM");
            dokter.Aktivitas();
            pasien.Aktivitas();

            Console.WriteLine("\n METHOD KHUSUS DOKTER");
            dokter.Diagnosa();
            dokter.CekPasien(pasien);
            Console.WriteLine("\nInformasi lengkap dokter:");
            dokter.InfoLengkap();

            Console.WriteLine("\n METHOD KHUSUS PASIEN ANAK");
            pasienAnak.Menangis();
            pasienAnak.Konsultasi();

            Console.WriteLine("\n POLYMORPHISM MELALUI VARIABEL ORANG");
            Orang orangPerawat = new Perawat("Dewi", 29, "IGD");
            orangPerawat.Aktivitas();

            Console.WriteLine("\n METHOD TAMBAHAN");
            dokter.CekSpesialis();
            pasien.CekKeluhan();
            perawat.CekPasien(pasien);
            pasienDewasa.Menangis();
            pasienDewasa.Konsultasi();

            Console.WriteLine("\nProgram selesai. Tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
        }
    }
}
