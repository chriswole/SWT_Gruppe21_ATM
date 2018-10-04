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
       

        ISeparation TestSeparation;
        List<Track> trackList;
        Position pos1, pos2, pos3, pos4;
        Track T1, T2, T3, T4;


        [SetUp]
        public void Setup()
        {
            TestSeparation = new Separation();
            trackList = new List<Track>();
            pos1 = new Position(27541,25884);
            pos2 = new Position(22513, 75141);
            pos3 = new Position(30245, 28884);
            T1 = new Track("H5JS", pos1,5422,251,150,"20181005");
            //T2 = new Track();
            // Skal test ingen danger 
            // alt too close, dist out of range
            // alt too close dist too close , not same tag

        }

        [Test]
        public void CalculateDistanceTest(List<Track> trackList)
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
