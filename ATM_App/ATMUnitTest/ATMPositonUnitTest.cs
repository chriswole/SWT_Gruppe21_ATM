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


namespace ATMUnitTest
{
    [TestFixture]
    [Author("Mette Jacobsen, Edited by members of group 21")]

    public class ATMPositonUnitTest
    {
        public Position uut;

        private int x, y;

        [SetUp]
        public void Setup()
        {
            x = 2000;
            y = 2000;
            uut = new Position(x, y);
        }

        [Test]
        public void PositionConstructorAndGetTest()
        {
            Assert.That(uut.x_,Is.EqualTo(x));
            Assert.That(uut.y_, Is.EqualTo(y));
        }

        [Test]
        public void PositionSetAndGetTest()
        {
            int x2 = 4000;
            int y2 = 1000;

            uut.x_ = x2;
            uut.y_ = y2;

            Assert.That(uut.x_,Is.EqualTo(x2));
            Assert.That(uut.y_,Is.EqualTo(y2));
        }
    }
}