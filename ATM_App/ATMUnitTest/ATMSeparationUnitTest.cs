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


        [SetUp]



        public void Setup()
        {
          
        }
        /*
        [Test]
        public void raiseAlarmIf()
        {
            TestSeparation.calculateDistances(trackList:);
            TestSeparation.newDangers_.Add(new Danger(Track track1: Track track2:  ));
            //Compares newDangers_ with OldDangers_
            if (TestSeparation.newDangers_.SequenceEqual(TestSeparation.OldDangers_))
            {
                //If Equal, print the tracks
                TestSeparation.newDangers_.ForEach(danger => Console.Write("Warning, the following planes are too close!\n{0}", newDangers_));
            }

        }

        [Test]
        public void raiseAlarmElse()
        {
            
        }

        [Test]
        public void deactivateAlarmTrue()
        {
            
        }

        [Test]
        public void deactivateAlarmFalse()
        {
            
        }*/

    }
}
