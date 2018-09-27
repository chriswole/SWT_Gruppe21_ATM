using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    class Seperation
    {
        public void calculateDistances(ToTrack toTrackObj)
        {
           
            foreach (var track1 in toTrackObj.tracks_)
            {
                foreach (var track2 in toTrackObj.tracks_)
                {
                    Position dist = track1.pos_ - track2.pos_;
                    dist = dist.x_
                }
                
            }
            
        }







































































































        public void raiseAlarm(Track tag1, Track tag2)
        {

        }

        public void deactivateAlarm(Track tag1, Track tag2)
        {
           
        }
    }
}
