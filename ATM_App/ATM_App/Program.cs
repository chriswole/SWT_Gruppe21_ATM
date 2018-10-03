using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using ATM;
using ATM.Interfaces;

namespace ATM_App
{
    class Program
    {
        static void Main(string[] args)
        {

            ITrack track1 = new Track();
            ITrack track2 = new Track("tag", new Position(1, 1));

            bool equals = track1 == track1;

            System.Console.WriteLine($"{equals}");

            equals = track1 == track2;

            System.Console.WriteLine($"{equals}");

            ToTrack testent = new ToTrack();

            string testdata = "ATR423;39045;12932;14000;20151006213456789";

            string[] strings = testent.ParseDataString(testdata);

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(strings[i]);
            }

            Track track = testent.BuildTrack(strings);

            System.Console.WriteLine($"{track.timestamp_}");

           //string trackString = track.ToString();

            ///System.Console.WriteLine(trackString);

            //foreach (var str in strings)
            //{
             //   System.Console.WriteLine(str);
                
            //}



        }
    }
}
