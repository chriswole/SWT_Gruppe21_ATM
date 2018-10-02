using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    class Danger :IDanger
    {
        public Danger(Track track1, Track track2, int dist)
        {
            track1_ = track1;
            track2_ = track2;
            distance_ = dist; 
        }
        public Track track1_ { get; set; }
        public Track track2_ { get; set; }
        public int distance_ { get; set; }

    }
}
