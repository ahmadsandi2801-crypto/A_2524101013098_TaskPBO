using System;

namespace ProjectRumahSakit
{
    public class PasienAnak : Pasien
    {
        public PasienAnak(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
        {
        }

        public void Menangis()
        {
            Console.WriteLine($"Pasien anak {Nama} menangis karena merasa takut atau tidak nyaman.");
        }

        public void Konsultasi()
        {
            Console.WriteLine($"Pasien anak {Nama} sedang berkonsultasi bersama orang tua/wali.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien anak {Nama} sedang menunggu pemeriksaan anak.");
        }
    }
}
