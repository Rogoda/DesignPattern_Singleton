using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Singleton
{
    public class Clock: ITimer
    {
        public DateTime Time { get; set; }

        public Clock(ITimer timer)
        {
            Time = timer.Time;
        }

    }
}
