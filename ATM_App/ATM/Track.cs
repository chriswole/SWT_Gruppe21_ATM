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
        Position pos_;
        private int altitude_;
        private int hori_velocity_;
        private int course_;
    }
}
