using System;
using Muhammed_Hatipoglu_Extension.OrtalamaExtension;

namespace Muhammed_Hatipoglu_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 3456;
            string sonuc = value.StringConversion();
            Console.WriteLine(sonuc +" "+ "değeri stringe çevrilmiştir.");
        }
    }
}
