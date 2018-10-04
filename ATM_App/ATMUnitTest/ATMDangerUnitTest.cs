using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM;
using ATM.Interfaces;
using NUnit.Framework;

namespace ATMUnitTest
{
    [TestFixture]
    class ATMDangerUnitTest
    {
        public Danger _uut;

        public ITrack track1_ { get; set; }
        public ITrack track2_ { get; set; }
        public int distance_ { get; set; }


        [SetUp]
        public void Setup()
        {
            track1_ = NSubstitute.Substitute.For<ITrack>();
            track2_ = NSubstitute.Substitute.For<ITrack>();

            _uut = new Danger(track1_, track2_,2500 );
        }
        /*
        [Test]
        public void CanNotChangeTracks()
        {
            track1_ = new ;
            Assert.That(_uut.track1_, Is.Not.EqualTo(t1));
        }*/
    }
}
