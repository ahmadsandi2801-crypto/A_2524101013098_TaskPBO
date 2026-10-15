using System;

namespace ProjectRumahSakit
{
    public class Perawat : TenagaMedis
    {
        public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi)
        {
        }

        public void CekPasien(Pasien pasien)
        {
            Console.WriteLine($"Perawat {Nama} sedang memantau kondisi pasien {pasien.Nama}.");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Perawat {Nama} sedang merawat dan memantau pasien.");
        }
    }
}
