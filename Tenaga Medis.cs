using System;

namespace ProjectRumahSakit
{
    public class TenagaMedis : Orang
    {
        public string Spesialisasi { get; set; }

        public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
        {
            Spesialisasi = spesialisasi;
        }

        public void CekSpesialis()
        {
            Console.WriteLine($"{Nama} memiliki spesialisasi: {Spesialisasi}");
        }

        public override void Aktivitas()
        {
            Console.WriteLine($"Tenaga medis {Nama} sedang memberikan pelayanan kesehatan.");
        }

        public override void InfoLengkap()
        {
            base.InfoLengkap();
            Console.WriteLine($"Spesialisasi: {Spesialisasi}");
        }
    }
}
