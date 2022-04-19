using System;

namespace Responsi
{
    class Karyawan
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public double GajiBulanan { get; set; }
        public void GajiNaik()
        {
            GajiBulanan += (GajiBulanan / 100) * 10;
        }
        public Karyawan(string nama, string nik, double gaji)
        {
            Nama = nama;
            Nik = nik;
            GajiBulanan = gaji < 0 ? 0 : gaji;
        }
    }
}