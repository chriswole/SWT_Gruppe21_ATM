using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Track:ITrack
    {
        public Track(string tag, Position pos, int altitude, int horiVelocity, int course)
        {
            string tag_ = tag;
            Position pos_ = pos;
            int altitude_ = altitude;
            int hori_velocity_ = horiVelocity;
            int course_ = course;
        }

        public string tag_ { get; set; }
        public Position pos_ { get; set; }
        public int altitude_ { get; set; }
        public int hori_velocity_ { get; set; }
        public int course_ { get; set; }
    }
}
