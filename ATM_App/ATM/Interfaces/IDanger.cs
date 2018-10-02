using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    interface IDanger
    {
        
        Track track1_ { get; set; }
        Track track2_ { get; set; }
        int distance_ { get; set; }
        void print();
    }
}
