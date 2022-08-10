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

            int currentSegundo = 0;
            int currentMinuto = 0;

            while (currentMinuto != minuto)
            {
                while (currentSegundo < 60)
                {
                    Console.Clear();
                    Console.WriteLine(currentMinuto + ":" + currentSegundo);
                    currentSegundo++;
                    Thread.Sleep(1000);
                }
                Console.Clear();
                currentMinuto++;
                currentSegundo = 0;
                Console.WriteLine(currentMinuto + ":" + currentSegundo);
                Thread.Sleep(1000);

            }

            while (currentSegundo != segundo)
            {
                Console.Clear();
                currentSegundo++;
                Console.WriteLine(minuto + ":" + currentSegundo);
                Thread.Sleep(1000);
            }

            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(1000);

            Menu();
        }
    }
}