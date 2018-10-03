using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using ATM;

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

        }
    }
}
