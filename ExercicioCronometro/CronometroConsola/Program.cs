﻿

namespace CronometroConsola
{
    using ExercicioCronometro;

    internal class Program
    {
        static void Main(string[] args)
        {
            var relogio = new Cronometro();
            Console.WriteLine("Pressione Enter para iniciar o cronometro");
            Console.ReadLine();

            relogio.StartClock();
            Console.WriteLine("Pressione Enter novamente para parar o cronometro");

            while (relogio.ClockState())
            {
                var tempo = DateTime.Now - relogio.StartTime();
                Console.Write("\r Tempo Corrente: {0}", tempo);

                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }

            relogio.StartClock();

            Console.WriteLine("\r Tempo Cronometro: {0}", relogio.GetTimeSpan());
            Console.ReadLine();
        }
    }
}
