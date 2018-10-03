using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    interface ISeparation
    {
        List<IDanger> newDangers_ { get; set; }
        List<IDanger> OldDangers_ { get; set; }

        void calculateDistances(IToTrack toTrackObj);
        void raiseAlarm();
        void deactivateAlarm();
    }
}
