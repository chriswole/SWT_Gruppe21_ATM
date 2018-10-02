using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    interface ISeparation
    {
        //List<IDanger> newDangers_;
        //List<IDanger> OldDangers_;

        void calculateDistances(ToTrack toTrackObj);
        void raiseAlarm();
        void deactivateAlarm();
    }
}
