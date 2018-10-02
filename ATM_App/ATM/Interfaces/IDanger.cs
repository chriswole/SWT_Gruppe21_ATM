using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    interface IDanger
    {
        
        ITrack track1_ { get; set; }
        ITrack track2_ { get; set; }
        int distance_ { get; set; }
        void print();
    }
}
