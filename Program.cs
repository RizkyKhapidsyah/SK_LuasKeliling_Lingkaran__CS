using System;

namespace SK_LuasKeliling_Lingkaran__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            string JariJari;
            double Konversi, Luas, Keliling;

            Console.Write("Masukkan Jari Jari  : ");
            JariJari = Console.ReadLine();

            Konversi = Convert.ToDouble(JariJari);

            Luas = PI * Konversi * Konversi;
            Keliling = 2 * PI * Konversi;

            Console.WriteLine("\nLuas Lingkaran      = {0}", Luas);
            Console.WriteLine("Keliling Lingkaran  = {0}", Keliling);
            Console.Read();
        }
    }
}
