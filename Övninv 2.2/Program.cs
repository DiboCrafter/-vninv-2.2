using System;
namespace Övning2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur långt hoppade du i meter?");
            string hoppade = Console.ReadLine();
            int hoppdade= int.Parse( hoppade );
            int suma = 3 + hoppdade; 
            Console.WriteLine("du hoppade" + " " + hoppade + " " + "meter" + " " + "men Elin hoppade" + " " + suma + " " + "meter");

        }
    }
}