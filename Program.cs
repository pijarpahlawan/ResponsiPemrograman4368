using System;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("Pijar", "21114368", 4000000);
            Karyawan karyawan2 = new Karyawan("Andi", "21115555", 6000000);

            PrintKaryawan(karyawan1, karyawan2);
            Console.WriteLine();
            karyawan1.GajiNaik();
            karyawan2.GajiNaik();
            Console.WriteLine();
            Console.WriteLine("Asyik kenaikan gaji 10%");
            PrintKaryawan(karyawan1, karyawan2);
        }

        static void PrintKaryawan(params Karyawan[] karyawan)
        {
            Console.WriteLine("No   NIK     Nama            Gaji Bulanan");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < karyawan.Length; i++)
            {
                Console.WriteLine($"{i + 1} {karyawan[i].Nik} {karyawan[i].Nama} {karyawan[i].GajiBulanan}");
            }
        }
    }
}