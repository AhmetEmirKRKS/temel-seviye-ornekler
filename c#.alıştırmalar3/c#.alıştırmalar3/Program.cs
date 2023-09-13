using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_.alıştırmalar3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim, soyisim;
         
            Console.WriteLine("Merhaba");
            Console.WriteLine("isminiz:");
            isim= Console.ReadLine();
            Console.WriteLine("Soyisim:");
            soyisim= Console.ReadLine();
            Console.WriteLine("Dogum yiliniz");
         string yilstr=Console.ReadLine();
            Console.Clear();
            int yil = Convert.ToInt32(yilstr);
            int yas = 2023- yil;
            Console.WriteLine(isim);
            Console.WriteLine(soyisim);
            Console.WriteLine(yas);
            Console.ReadLine();
        }
    }
}
