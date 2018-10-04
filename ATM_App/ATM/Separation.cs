using ATM.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace ATM
{
    public class Separation : ISeparation
    {
        public List<IDanger> newDangers_ { get; set; }
        public List<IDanger> OldDangers_ { get; set; }


        public event EventHandler Warning;
        

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







        public void raiseAlarm()
        {
            //Compares newDangers_ with OldDangers_ and removes matching elements from newDangers_
            var newDangers = newDangers_.Except(OldDangers_);
            foreach (var dangerObj in newDangers_)
            {

                newDangers_.ForEach(danger => Console.Write("Warning, the following planes are too close!\n{0}",newDangers_));
            }

            //System.Threading.Thread.Sleep(5000);
            // newDangers_.ForEach(Console.Write("{0}\t", newDangers_));

        }

        public void deactivateAlarm()
        {
            //Compares newDangers_ with OldDangers_ and removes matching elements from OldDangers_
            var oldDangers = OldDangers_.Except(newDangers_);

        }
    }
}
