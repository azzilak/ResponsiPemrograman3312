using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3312
{
    public class Karyawan
    {
            public Karyawan(int Urut, int nik, string Name, int Gaji)
            {
                Urutan = Urut;
                NIK = nik;
                Nama = Name;
                GajiBulanan = Gaji;

            }

            public int Urutan { get; set; }
            public int NIK { get; set; }
            public string Nama { get; set; }
            public int GajiBulanan { get; set; }

        public void Output1()
        {
            Console.WriteLine("{0}. {1}  {2}           {3}", Urutan, NIK, Nama, GajiBulanan);
            if (GajiBulanan < 0)
            {
                Console.WriteLine("Maaf Gaji kurang dari ");
            }

        }
        public void Output2()
        {
            Console.WriteLine("{0}. {1}  {2}           {3}", Urutan, NIK, Nama, GajiBulanan+ (GajiBulanan * 0.1));
            if (GajiBulanan < 0)
            {
                Console.WriteLine("Maaf Gaji kurang dari ");
            }
        }

        //public void Output2()
        //{
        // Console.WriteLine("{0}. {1}   {2}         {3}", Urutan, NIK, Nama, GajiBulanan + (GajiBulanan * 0.1));

        //}
    }
}
