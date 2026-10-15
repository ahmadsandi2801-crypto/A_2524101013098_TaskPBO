using System;

namespace ProjectRumahSakit
{
    public class Pasien : Orang
    {
        public string Keluhan { get; set; }

        public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
        {
            Keluhan = keluhan;
        }

        public void CekKeluhan()
        {
            Console.WriteLine($"Keluhan {Nama}: {Keluhan}");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Pasien {Nama} sedang menunggu atau menjalani pemeriksaan.");
        }

        public override void InfoLengkap()
        {
            base.InfoLengkap();
            Console.WriteLine($"Keluhan: {Keluhan}");
        }
    }
}
