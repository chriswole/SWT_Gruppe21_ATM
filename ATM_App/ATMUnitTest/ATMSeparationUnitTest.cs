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


namespace ATMUnitTest
{
    [TestFixture]
    class ATMSeparationUnitTest
    {
       

        ISeparation TestSeparation = new Separation();


        [SetUp]



        public void Setup()
        {
            
            TestSeparation.newDangers_ = new List<Danger>();
            TestSeparation.OldDangers_ = new List<Danger>();
            //NSubstitute.Substitute.For<Danger>()
        }

        [Test]
        public void raiseAlarmTrue()
        {

            List<Danger> results = new List<Danger>();
            
            Assert.IsTrue(TestSeparation.newDangers_.Except(TestSeparation.OldDangers_).Count()==0);
        }

        [Test]
        public void raiseAlarmFalse()
        {
            List<Danger> results = new List<Danger>();

            Assert.IsFalse(TestSeparation.newDangers_.Except(TestSeparation.OldDangers_).Count() == 0);
        }

        [Test]
        public void deactivateAlarmTrue()
        {
            List<Danger> results = new List<Danger>();

            Assert.IsTrue(TestSeparation.OldDangers_.Except(TestSeparation.newDangers_).Count() == 0);
        }

        [Test]
        public void deactivateAlarmFalse()
        {
            List<Danger> results = new List<Danger>();

            Assert.IsFalse(TestSeparation.OldDangers_.Except(TestSeparation.newDangers_).Count() == 0);
        }

    }
}
