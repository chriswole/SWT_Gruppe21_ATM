using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM;
using NSubstitute;
using NUnit.Framework;
using TransponderReceiver;

namespace ATMUnitTest
{
    class ATMToTrackUnitTest
    {

        private ITransponderReceiver _fakeTransponderReceiver;
        private ToTrack _uut;
        [SetUp]
        public void Setup()
        {
            // Make a fake Transponder Data Receiver
            _fakeTransponderReceiver = Substitute.For<ITransponderReceiver>();
            // Inject the fake TDR
            _uut = new ToTrack(_fakeTransponderReceiver);
        }

        [Test]
        public void ParseDataString_Test()
        {
            string[] tokens_;

            string data = "ATR423;39045;8500;14000;20151006213456789";
            string[] rightTokens = new string[] {"ATR423", "39045", "8500", "14000", "20151006213456789"};
            tokens_ = _uut.ParseDataString(data);

            for (int i = 0; i < 5; i++)
            {
                Assert.That(tokens_[i], Is.EqualTo(rightTokens[i]));
            }

            data = "ATR500;39045;7500;14000;20151006213456789";

             rightTokens = new string[] { "ATR500", "39045", "7500", "14000", "20151006213456789" };
            tokens_ = _uut.ParseDataString(data);

            for (int i = 0; i < 5; i++)
            {
                Assert.That(tokens_[i], Is.EqualTo(rightTokens[i]));
            }

            data = "ATR600;500;500;14000;20151006213456789";

            rightTokens = new string[] { "ATR600", "500", "500", "14000", "20151006213456789" };
            tokens_ = _uut.ParseDataString(data);

            for (int i = 0; i < 5; i++)
            {
                Assert.That(tokens_[i], Is.EqualTo(rightTokens[i]));
            }

            data = "ATR700;12000;12000;14000;20151006213456789";

            rightTokens = new string[] { "ATR700", "12000", "12000", "14000", "20151006213456789" };
            tokens_ = _uut.ParseDataString(data);

            for (int i = 0; i < 5; i++)
            {
                Assert.That(tokens_[i], Is.EqualTo(rightTokens[i]));
            }



        }

       /* [Test]
        public void TestDataReception()
        {
            // Setup test data
        
            List<string> testData = new List<string>();
            testData.Add("ATR423;39045;12932;14000;20151006213456789");
            testData.Add("BCD123;10005;85890;12000;20151006213456789");
            testData.Add("XYZ987;25059;75654;4000;20151006213456789");

            // Act: Trigger the fake object to execute event invocation
            _fakeTransponderReceiver.TransponderDataReady
                += Raise.EventWith(this, new RawTransponderDataEventArgs(testData));

            Assert.That(_uut.Tracks.Count, Is.EqualTo(1));


          
        }*/

       
    }
}
