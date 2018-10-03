using System;
using System.Runtime.Remoting.Services;
using ATM;//Hvorfor bliver du ved med at være rød?! 
using ATM.Interfaces.ITrack;
using ATM.Interfaces.I
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using NUnit.Framework.Internal;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTrackUnitTest
{
    [TestFixture]
    [Author("Mette Jacobsen, Edited by members of group 21")]
    public class ATMTrackUnitTest
    {
       
        [TestClass]
        class ITrackTest
        {
            public string tag_ = "Mc238";
            public IPosition pos_ = new IPosition();
            public x_= 20000;
            public y_= 20000;
            public int altitude_ = 10000;
            public int hori_velocity_ = horiVelocity;
            public int course_ = course;
            public ITrack track_;

            [Setup]
            public void Setup()
            {
                pos_.SetPosition(x_, y_);
                track_ = new ITrack(tag_, pos_, altitude_, hori_velocity_, course_);
            }

        }
        //[TestCase(x,x,x,x,x,t/f)]
        //public void make_ITrack(string tag, Position pos, int altitude, int horivelocity, int course, bool result)
        //{
        //    Assert.That();
        //}
    }
}
