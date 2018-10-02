using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;


namespace ATM
{
    class Separation : ISeparation
    {
        public List<IDanger> newDangers_;
        public List<IDanger> OldDangers_;

        public Separation()
        {
            newDangers_ = new List<IDanger>();
            OldDangers_ = new List<IDanger>();
        }

        public void calculateDistances(ToTrack toTrackObj)
        {
            foreach (var track1 in toTrackObj.Tracks)
            {
                foreach (var track2 in toTrackObj.Tracks)
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

       





        public void raiseAlarm()
        {

        }

        public void deactivateAlarm()
        {
           
        }
    }
}
