using System;
namespace console_programlama
{
    class Program
    {


        public static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("isminizi girin:");
            string name = Console.ReadLine() ?? throw new Exception();
            Console.WriteLine("Soyisminizi girin");
            string surname = Console.ReadLine() ?? throw new Exception();
            Console.WriteLine("Merhaba," + name + " " + surname);
            int deger = 5;
            float deger1 = 9;
            double d1 = 15.536;
            DateTime dt1 = DateTime.Now;
            Int16 i16 = 26;
            Int32 i32 = 32;
            Int64 i64 = 64;
            bool t1 = true;
            string tamIsim = name + " " + surname;



        }
    }
}