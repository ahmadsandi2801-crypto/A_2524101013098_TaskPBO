using System;
using System.Collections.Generic;

namespace ProjectRumahSakit
{
    public class RumahSakit
    {
        private readonly List<Orang> daftarOrang = new List<Orang>();

        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
            Console.WriteLine($"{orang.Nama} berhasil ditambahkan ke daftar rumah sakit.");
        }

        public void DaftarOrang()
        {
            Console.WriteLine("\n DAFTAR ORANG DI RUMAH SAKIT");
            foreach (Orang orang in daftarOrang)
            {
                Console.WriteLine("------------------------------");
                orang.InfoLengkap();
                Console.Write("Aktivitas: ");
                orang.Aktivitas();
            }
            Console.WriteLine("------------------------------");
        }
    }
}
