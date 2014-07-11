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

            Hand myHand = new Hand("5H 5S 5D 5C 4D");
            myHand.PokerHand();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
