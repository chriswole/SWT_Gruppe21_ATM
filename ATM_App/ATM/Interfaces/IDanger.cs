using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    public interface IDanger
    {
        
        ITrack track1_ { get; }
        ITrack track2_ { get; }
        int distance_ { get; }
        void print();
    }
}
