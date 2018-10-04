using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ATM;
using NUnit.Framework;
using ATM.Interfaces;
using NUnit.Framework.Internal;


namespace ATMUnitTest
{
    [TestFixture]
    class ATMSeparationUnitTest
    {
       

        ISeparation TestSeparation = new Separation();
        Track track1_ = new Track();
        Track track2_ = new Track();
        int dist;

        [SetUp]



        public void Setup()
        {
          
        }

        [Test]
        public void raiseAlarmTrue()
        {
            
            Assert.IsTrue(TestSeparation.newDangers_.Except(TestSeparation.OldDangers_).Count()==0);
        }

        [Test]
        public void raiseAlarmFalse()
        {
            TestSeparation.newDangers_.Add(new Danger(track1_, track2_, dist));
            Assert.IsFalse(TestSeparation.newDangers_.Except(TestSeparation.OldDangers_).Count() == 0);
        }

        [Test]
        public void deactivateAlarmTrue()
        {
            Assert.IsTrue(TestSeparation.OldDangers_.Except(TestSeparation.newDangers_).Count() == 0);
        }

        [Test]
        public void deactivateAlarmFalse()
        {
            TestSeparation.newDangers_.Add(new Danger(track1_, track2_, dist));
            TestSeparation.newDangers_.Add(new Danger(track1_, track2_, dist));
            Assert.IsFalse(TestSeparation.OldDangers_.Except(TestSeparation.newDangers_).Count() == 0);
        }

    }
}
