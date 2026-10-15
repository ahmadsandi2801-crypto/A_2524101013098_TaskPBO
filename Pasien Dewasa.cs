using System;

namespace ProjectRumahSakit
{
    public class PasienDewasa : Pasien
    {
        public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
        {
        }

        public void Menangis()
        {
            Console.WriteLine($"Pasien dewasa {Nama} sedang menangis.");
        }

        public void Konsultasi()
        {
            Console.WriteLine($"Pasien dewasa {Nama} sedang berkonsultasi dengan dokter.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien dewasa {Nama} sedang menjalani proses pemeriksaan.");
        }
    }
}
