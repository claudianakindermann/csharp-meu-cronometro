using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("---------- Cronômetro ----------");
            Console.WriteLine("Informe o tempo no formato MM:SS");
            string time = Console.ReadLine();

            int minuto = int.Parse(time.Substring(0, 2));
            int segundo = int.Parse(time.Substring(3, 2));

            Start(minuto, segundo);

        }
        static void Start(int minuto, int segundo)
        {

            int currentMinuto = 0;

            while (currentMinuto != minuto)
            {
                ContaSegundos(currentMinuto, 60);
                Console.Clear();
                currentMinuto++;
                Console.WriteLine(currentMinuto + ":00");
                Thread.Sleep(1000);
            }

            ContaSegundos(currentMinuto, segundo + 1);

            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(1000);

            Menu();
        }

        static void ContaSegundos(int currentMinuto, int duracaoSegundos)
        {
            int currentSegundo = 0;

            while (currentSegundo < duracaoSegundos)
            {
                Console.Clear();
                Console.WriteLine(currentMinuto + ":" + currentSegundo);
                currentSegundo++;
                Thread.Sleep(1000);
            }
        }

    }
}