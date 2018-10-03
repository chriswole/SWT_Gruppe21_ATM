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
        public List<IDanger> newDangers_ { get; set; }
        public List<IDanger> OldDangers_ { get; set; }


        public Separation()
        {
            newDangers_ = new List<IDanger>();
            OldDangers_ = new List<IDanger>();
        }

        public void calculateDistances(IToTrack toTrackObj)
        {
            foreach (var track1 in toTrackObj.Tracks)
            {
                foreach (var track2 in toTrackObj.Tracks)
                {
                    // Are the planes within same altitude layer
                    int alt = Math.Abs(track1.altitude_ - track2.altitude_);
                    if (alt < 300)
                    {
                        // are the planes too close in xy-plane
                        Position dist = track1.pos_ - track2.pos_;
                        var distance = Math.Sqrt(dist.x_ ^ 2 + dist.y_ ^ 2);
                        if (distance < 5000)
                        {
                            // Is the planes actually the same - if not make a dangerObj
                            if (!(track1.Equals(track2)))
                            {
                                Danger dangerObj = new Danger(track1, track2, (int) distance);
                                newDangers_.Add(dangerObj);
                            }
                        }
                    }
                }
            }
        }

       





        public void raiseAlarm(IDanger alarm, ISeparation objects)
        {
            foreach (var danger in objects.newDangers_)
            {
                alarm.print();
            }
        }

        public void deactivateAlarm()
        {
           
        }
    }
}
