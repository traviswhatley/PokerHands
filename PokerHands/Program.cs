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

            PokerHand("5H 4D TS 5D 4S");



            Console.ReadKey();
        }

        static void PokerHand(string input)
        {
            var myHand = new Hand(input);
        }
    }
}
