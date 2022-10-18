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
            string fullName = "Merhaba," + name + " " + surname;
            Console.WriteLine(fullName);
            int deger = 5;
            float deger1 = 9;
            double d1 = 15.536;
            DateTime dt1 = DateTime.Now;
            Int16 i16 = 26;
            Int32 i32 = 32;
            Int64 i64 = 64;
            bool t1 = true;
            string tamIsim = name + " " + surname;
            byte b = 5;   //1 byte
            sbyte sb = 5; //1byte
            short s2 = 5;   //2byte
            ushort us = 5;  //2byte
            uint ui = 8;      //4byte
            ulong ul = 5;     //8byte
            float f = 48;     //4byte
            double d4 = 56.5;   //8bye
            decimal de = 52;  //16byte
            char c = 'd';         //2byte
            object o1 = 'f';
            object o2 = 5;
            object o3 = "hi";

            string age = "I am " + ui.ToString() + " years old.";
            Console.WriteLine(age + Environment.NewLine + fullName + Environment.NewLine + us + Environment.NewLine + dt1);


        }
    }
}