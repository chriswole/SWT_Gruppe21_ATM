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
            string timestamp = "" )
        {
            tag_ = tag;
            pos_ =  pos == null ? new Position(0,0) : pos;
            altitude_ = altitude;
            hori_velocity_ = horiVelocity;
            course_ = course;
            timestamp_ = timestamp;
        }

        public string tag_ { get; set; }
        public Position pos_ { get; set; }
        public int altitude_ { get; set; }
        public int hori_velocity_ { get; set; }
        public int course_ { get; set; }
        public string timestamp_{get; set;}

        public override string ToString()
        {
            string str = $"Track:\n " +
                         $"{tag_}\n " +
                         $"{pos_.x_},{pos_.y_}\n " +
                         $"{altitude_}\n " +
                         $"{hori_velocity_}\n " +
                         $"{timestamp_}\n";
            return str;
        }
    }
}
