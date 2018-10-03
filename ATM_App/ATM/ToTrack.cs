using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    class ToTrack : IToTrack
    {
        public List<ITrack> Tracks { get; set; }

        public ToTrack()
        {
            Tracks = new List<ITrack>();
        }

       

    }
}
