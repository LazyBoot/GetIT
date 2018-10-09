using PomodoroEngine;
using System;

namespace OppgaveInterface
{
    class Program : INotifyObject
    {
        static void Main(string[] args)
        {
            var program = new Program();
            Console.ReadLine();
        }

        public Program()
        {
            var pomodoro = new Pomodoro(this, 1);
            pomodoro.Start();
        }

        public void Tick(int minutes, int seconds)
        {
            Console.Clear();

            if (minutes == 0 && seconds == 0)
            {
                Console.WriteLine("Ta pause");
                Environment.Exit(0);
            }
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}
