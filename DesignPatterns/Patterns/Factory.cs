using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns
{
    public struct Factory
    {
        private readonly long ticks;

        public long Ticks { get { return ticks; } }

        public Factory(long ticks)
        {
            this.ticks = ticks;
        }

        public static Factory FromTicks(long ticks)
        {
            return new Factory(ticks);
        }

    }
}
