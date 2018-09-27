using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class ToTrack
    {
        private List<Track> tracks_;

        public ToTrack()
        {
            tracks_ = new List<Track>();
        }

        public List<Track> Tracks
        {
            get { return tracks_;}

        }

    }
}
