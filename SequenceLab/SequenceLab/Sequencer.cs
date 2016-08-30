using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceLab
{
    public class Sequencer : ISequence
    {
        public int TailorSeries()
        {
            return 5*5;//test return value...
        }

        public double MacLaureenSeries(double a, double b)
        {
            return a * 3 + b + 2;
        }
    }
}
