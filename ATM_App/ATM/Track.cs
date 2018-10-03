using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    public class Track : ITrack
    {
        public Track(string tag = "", Position pos = null, int altitude = 0, int horiVelocity = 0, int course = 0,
            int timestamp = 0)
        {
            string tag_ = tag;
            Position pos_ = pos;
            int altitude_ = altitude;
            int hori_velocity_ = horiVelocity;
            int course_ = course;
            int timestamp_ = timestamp;
        }

        public string tag_ { get; set; }
        public Position pos_ { get; set; }
        public int altitude_ { get; set; }
        public int hori_velocity_ { get; set; }
        public int course_ { get; set; }
        public int timestamp_{get; set;}

}
}
