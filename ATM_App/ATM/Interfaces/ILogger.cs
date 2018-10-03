using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Interfaces
{
    interface ILogger
    {
        void AddToLog(IDanger danger2Log);
    }
}
