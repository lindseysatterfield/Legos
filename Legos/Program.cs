using Legos.Heads;
using System;
using System.Collections.Generic;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();

            workerHead.Color = LegoColor.Yellow;
            workerHead.SayHi();

            var batmanHead = new BatmanHead();
            batmanHead.SayHi();

            var astronautHead = new AstronautHead();
            astronautHead.SayHi();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };

            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }

        }
    }
}
