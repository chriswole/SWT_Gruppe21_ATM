using System;
using System.Runtime.Remoting.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using NUnit.Framework.Internal;

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ATM;
using ATM.Interfaces;
using Track = ATM.Track;

namespace ATMTrackUnitTest
{
    [TestFixture]
    [Author("Mette Jacobsen, Edited by members of group 21")]


    class TrackTest
    {

        public Track uut;
        string tag, timestamp;
        Position pos;
        private int altitude, hori_velocity, course;


        [SetUp] //Husk stort U!
        public void Setup()
        {
            pos = new Position(50000, 40000);
            tag = "MJ2412";
            altitude = 20000;
            hori_velocity = 400;
            course = 90;
            timestamp = "20181224";
            uut = new Track(tag, pos, altitude, hori_velocity, course, timestamp);

         }
        [Test] 
        public void TrackConstrucctorAndGetTest()
        {
            Assert.That(uut.tag_, Is.EqualTo(tag));
            Assert.That(uut.pos_, Is.EqualTo(pos));
            Assert.That(uut.altitude_, Is.EqualTo(altitude));
            Assert.That(uut.hori_velocity_, Is.EqualTo(hori_velocity));
            Assert.That(uut.course_, Is.EqualTo(course));
            Assert.That(uut.timestamp_, Is.EqualTo(timestamp));

        }
        [Test]
        public void TrackSetAndGetTest()
        {

            Position pos2 = new Position(2000, 2000);
            string tag2 = "Mc238";
            int altitude2 = 10000;
            int hori_velocity2 = 200;
            int course2 = 89;
            string timestamp2 = "20180423";

            uut.tag_ = tag2;
            uut.pos_ = pos2;
            uut.altitude_ = altitude2;
            uut.hori_velocity_ = hori_velocity2;
            uut.course_ = course2;
            uut.timestamp_ = timestamp2;

            Assert.That(uut.tag_, Is.EqualTo(tag2));
            Assert.That(uut.pos_, Is.EqualTo(pos2));
            Assert.That(uut.altitude_, Is.EqualTo(altitude2));
            Assert.That(uut.hori_velocity_, Is.EqualTo(hori_velocity2));
            Assert.That(uut.course_, Is.EqualTo(course2));
            Assert.That(uut.timestamp_, Is.EqualTo(timestamp2));

        }

    }

}




