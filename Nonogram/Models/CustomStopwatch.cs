using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram.Models
{
    public class CustomStopwatch : Stopwatch
    {
        public TimeSpan StartOffset { get; private set; }


        public CustomStopwatch(TimeSpan startOffset)
        {
            StartOffset = startOffset;
        }

        public new long ElapsedMilliseconds
        {
            get
            {
                return base.ElapsedMilliseconds + (long)StartOffset.TotalMilliseconds;
            }
        }

        public new long ElapsedTicks
        {
            get
            {
                return base.ElapsedTicks + StartOffset.Ticks;
            }
        }
    }
}
