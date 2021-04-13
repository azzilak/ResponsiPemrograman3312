using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3312
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("No. Nik/Nama                   Gaji Bulanan");
            Console.WriteLine("-------------------------------------------");
                
            Karyawan karyawan1 = new Karyawan(1, 190302123, "Azzila ", 3000000);
            karyawan1.Output1();

            Karyawan karyawan2 = new Karyawan(2, 190302124, "Karen   ", 2000000);
            karyawan2.Output1();

            Console.WriteLine("");
            Console.WriteLine("Alhamdulillah dapat kenaikan gaji 10%!!!");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("No Nik/Nama                   Gaji Bulanan");
            Console.WriteLine("------------------------------------------");
            Karyawan kenaikan1 = new Karyawan(1, 190302123, "Azzila ", 3000000);
            kenaikan1.Output2();
            Karyawan kenaikan2 = new Karyawan(2, 190302124, "Karen   ", 2000000);
            kenaikan2.Output2();
            Console.ReadKey(true);
        }
    }

}
