using System;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Pijar", "21114368", 4000000);
            Karyawan karyawan2 = new Karyawan("Andi", "21115555", 6000000);

            Console.WriteLine("No   NIK     Nama            Gaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{karyawan1.Nama} {karyawan1.Nik} {karyawan1.Nama} {karyawan1.GajiBulanan}");
            Console.WriteLine($"{karyawan2.Nama} {karyawan2.Nik} {karyawan2.Nama} {karyawan2.GajiBulanan}");
            Console.WriteLine();
            karyawan1.GajiNaik();
            Console.WriteLine("Asyik kenaikan gaji 10%");
            karyawan2.GajiNaik();
            Console.WriteLine();
            Console.WriteLine("No   NIK     Nama            Gaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"{karyawan1.Nama} {karyawan1.Nik} {karyawan1.Nama} {karyawan1.GajiBulanan}");
            Console.WriteLine($"{karyawan2.Nama} {karyawan2.Nik} {karyawan2.Nama} {karyawan2.GajiBulanan}");
        }
    }
}