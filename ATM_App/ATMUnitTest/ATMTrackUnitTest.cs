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
  
       
        [TestClass]
        class ITrackTest
        {
            public ITrack track_ = new Track();

            [Setup]//BUT WHY!
            public void Setup()
            {
                track_.tag_ = "Mc238";
                track_.pos_ = new Position(2000, 2000);
                track_.altitude_ = 10000;
                track_.hori_velocity_ = 2000;
                track_.course_ = 89;


            }

        }
        
    
}
