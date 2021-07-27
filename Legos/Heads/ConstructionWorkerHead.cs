using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legos.Heads
{
    class ConstructionWorkerHead : HeadBase
    {
        public bool HasMullet { get; set; }
        //public string Color { get; set; }
        //public LegoColor Color { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;

            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not ")} wearing their hard hat.");

            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0)
            {
                NumberOfTeeth -= 1;
            }
           
            Console.WriteLine($"The {Color} Construction Worker Head spins after bring hit by girder.");
        }

        //public void SayHi()
        //{
        //    Console.WriteLine("The Construction Worker Head says hello.");
        //}
    }
}
