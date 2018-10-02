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
        public void print()// the altitude is per definition less than 300, otherwise danger isn't created. 
        {
            Console.Write("%d and %d Distance: %d", track1_.tag_, track2_.tag_, distance_);
        }

    }
}
