using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ATM.Interfaces
{
    public interface ITrack
    {
        string tag_ { get; set; }
        Position pos_ { get; set; }
        int altitude_ { get; set; }
        int hori_velocity_ { get; set; }
        int course_ { get; set; }
        int timestamp_ { get; set; }
    }
}