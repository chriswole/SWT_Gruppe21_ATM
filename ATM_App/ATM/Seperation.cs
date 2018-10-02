using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    class Seperation
    {
        public List<Danger> newDangers_;
        public List<Danger> OldDangers_;

        public Seperation()
        {
            newDangers_ = new List<Danger>();
            OldDangers_ = new List<Danger>();
        }

        public void calculateDistances(ToTrack toTrackObj)
        {
            foreach (var track1 in toTrackObj.tracks_)
            {
                foreach (var track2 in toTrackObj.tracks_)
                {
                    Position dist = track1.pos_ - track2.pos_;
                    var distance = Math.Sqrt(dist.x_ ^ 2 + dist.y_ ^ 2);
                    if (distance<5000)
                    {
                        int alt = Math.Abs(track1.altitude_ - track2.altitude_);
                        if (alt<300)
                        {
                            Danger dangerObj = new Danger(track1, track2, (int) distance);
                            newDangers_.Add(dangerObj);
                            
                        }
                    }
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
