using System;
using System.Runtime.Remoting.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using NUnit.Framework.Internal;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM;
using ATM.Interfaces;

namespace ATMTrackUnitTest
{
    [TestFixture]
    [Author("Mette Jacobsen, Edited by members of group 21")]


    class ITrackTest
    {
        public ITrack Track1 = new Track();

        public ITrack Ib
        {
            get => Track1;
            set => Track1 = value;
        }

        [SetUp] //Husk stort U!
        public void Setup()
        {
            Track1.tag_ = "Mc238";
            Track1.pos_ = new Position(2000, 2000);
            Track1.altitude_ = 10000;
            Track1.hori_velocity_ = 2000;
            Track1.course_ = 89;
            Track1.timestamp_ = "12:00"; //hvordan skal de sættes?

        }

        /*[TestCase] //eller (Test)

    */
    }

}
        
    
