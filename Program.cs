using System;

namespace pc_etec1b_projeto_medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros = 0.0, cm = 0.0, km = 0.0;

            Console.Write("digite uma medida em metros: ");
            metros = Convert.ToDouble(Console.ReadLine());

            cm = metros * 100;
            km = metros / 1000;

            Console.WriteLine("--- Equivalência ---\n"+cm+" cm\n"+metros+" m\n"+km+" KM");
            Console.ReadKey();
        }
    }
}
