using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Card
    {
        //establishing card properties
        public int Rank { get; set; }
        public string Suit { get; set; }

        //defining constructors
        public Card(string cardString)
        {
            //get rank from string
            string tempRank = cardString[0].ToString();
            //excute code base on tempRank value
            switch (tempRank)
            {
                case "T":
                    this.Rank = 10;
                    break;
                case "J":
                    this.Rank = 11;
                    break;
                case "Q":
                    this.Rank = 12;
                    break;
                case "K":
                    this.Rank = 13;
                    break;
                case "A":
                    this.Rank = 14;
                    break;
                default:
                    //not a 10, or royal card, it's a number
                    this.Rank = int.Parse(tempRank);
                    break;
            }
            //set suit
            this.Suit = cardString[1].ToString();
        }
    }
}
