using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ATM.Interfaces;

namespace ATMUnitTest
{
    [TestFixture]
    class ATMSeparationUnitTest
    {
        public List<IDanger> newDangers_ { get; set; }
        public List<IDanger> oldDangers_ { get; set; }

        [SetUp]
        public void Setup()
        {
            newDangers_ = new List<IDanger>();
            oldDangers_ = new List<IDanger>();
            //NSubstitute.Substitute.For<IDanger>()
        }






    }
}
