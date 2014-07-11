using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Program
    {
        static void Main(string[] args)
        {

            Hand myHand = new Hand("TS JS QS KS AS");
            myHand.PokerHand();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
