using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceLab
{
    public interface ISequence
    {
        int TailorSeries();
        double MacLaureenSeries(double a, double b);
    }
}
