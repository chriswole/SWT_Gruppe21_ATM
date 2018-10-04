using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    public class Danger :IDanger
    {
        //Constructor
        public Danger(Track track1, Track track2, int dist)
        {
            track1_ = track1;
            track2_ = track2;
            distance_ = dist; 
        }
        // the tracks that are closing in and  their distance
        public Track track1_ { get; private set; }
        public Track track2_ { get; private set; }
        public int distance_ { get; private set; }
        // the print function for Danger
        // the altitude is per definition less than 300, otherwise danger isn't created. 
        public void print()
        {
            Console.Write("%s and %s Distance: %d", track1_.tag_, track2_.tag_, distance_);
        }

    }
}
