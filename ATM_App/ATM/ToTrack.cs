using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;
using TransponderReceiver;

namespace ATM
{
    public class ToTrack : IToTrack
    {
        public List<ITrack> Tracks { get; set; }

        private ITransponderReceiver receiver;

        public ToTrack()
        {
            Tracks = new List<ITrack>();

            // This will store the real or the fake transponder data receiver
            //this.receiver = receiver;

            // Attach to the event of the real or the fake TDR
            //this.receiver.TransponderDataReady += ReceiverOnTransponderDataReady;
        }

        

       

        private void ReceiverOnTransponderDataReady(object sender, RawTransponderDataEventArgs e)
        {
            // Just display data
            foreach (var data in e.TransponderData)
            {
               // System.Console.WriteLine($"Transponderdata {data}");
            }
        }

        public string[] ParseDataString(string datastr)
        {

            string[] result;
            char[]charSeperators = new char[] {';'};

            result = datastr.Split(charSeperators, StringSplitOptions.RemoveEmptyEntries);

            return result;
        }


        public Track BuildTrack(string[] stringArr)
        {

           Track track_ = new Track();

            track_.tag_ = (string) stringArr[0];
            track_.pos_.x_ = int.Parse(stringArr[1]);
            track_.pos_.y_ = int.Parse(stringArr[2]);
            track_.altitude_ = int.Parse(stringArr[3]);
            track_.timestamp_ = stringArr[4];
            
            return track_;
 
        }




    }
}
