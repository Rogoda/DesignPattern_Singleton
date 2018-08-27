using System;
using System.Collections.Generic;

namespace DesignPattern_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITimer> timers = new List<ITimer>();

            var master = new FirstClock();
            Console.WriteLine("Macter clock's time: {0}",master.Time);

            for(int i = 0; i < 10; i++)
            {
                var clock = new Clock(master.GetInstance());
                timers.Add(clock);
                Console.WriteLine("{0} clock's time: {1}", i+1 , clock.Time);
            }

        }
    }
}
