using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int hasil;
            Calculator calculator = new Calculator();
            hasil = calculator.Penjumlahan(10, 2);
            Cetakhasil("10 + 2 " + hasil);
            hasil = calculator.Penjumlahan(10, 2, 3);
            Cetakhasil("10 + 2 + 3 " + hasil);
            hasil = calculator.Pengurangan(7, 2);
            Cetakhasil("7 - 2 = " + hasil);
            hasil = Calculator.Perkalian(5, 2);
            Cetakhasil("5 x 2 =" + hasil);
            Console.ReadKey();
        }
        public static void Cetakhasil(string hasil)
        {
            Console.WriteLine(hasil); 
        }
    }
}