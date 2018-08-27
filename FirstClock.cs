using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Singleton
{
    class FirstClock : ITimer
    {
        public DateTime Time { get; private set; }

        public FirstClock()
        {
            Time = DateTime.Now;
        }

        public ITimer GetInstance()
        {
            return this;
        }
    }
}
