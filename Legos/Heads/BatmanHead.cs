using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legos.Heads
{
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";
        //public LegoColor Color => LegoColor.Black;
        public BatmanHead()
        {
            Color = LegoColor.Black;
        }

        public override void Spin()
        {
            Console.WriteLine("Where is the joker?!?!");
        }

        public override void SayHi()
        {
            Console.WriteLine("I'm Batman!");
        }
    }
}
