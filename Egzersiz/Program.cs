using System;

namespace Egzersiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Dersler dersler1 = new Dersler();
            dersler1.Adi = "Mehmet";
            dersler1.DersDili = "Python";

            Dersler dersler2 = new Dersler();
            dersler2.Adi = "Eren";
            dersler2.DersDili = "C#";

            Dersler dersler3 = new Dersler();
            dersler3.Adi = "Can";
            dersler3.DersDili = "Java";

            Dersler[] ders = new Dersler[]
            {
                dersler1,dersler2,dersler3
            };

            foreach (var yaz in ders)
            {
                Console.WriteLine(yaz.DersDili + ":" + yaz.Adi);
            }
        }
        class Dersler
        {
            public string Adi { get; set; }
            public string DersDili { get; set; }
            
        }
    }
}
