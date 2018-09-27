using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Track
    {
        public Track(string tag, Position pos, int altitude, int horivelocity, int course)
        {
            string tag_ = tag;
            Position pos_ = pos;
            int altitude_ = altitude;
            int hori_velocity_ = horivelocity;
            int course_ = course;
        }

        private string tag_;
        public Position pos_ { get; set; }
        public int altitude_ { get; set; }
        private int hori_velocity_;
        private int course_;
    }
}
