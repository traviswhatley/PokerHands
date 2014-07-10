﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    class Hand
    {
        //defining hand properties
        public List<Card> Cards { get; set; }

        //define constructors for the hand
        public Hand(string handString)
        {
            //intializing Cars
            this.Cards = new List<Card>();
            //splitting on the space
            var tempList = handString.Split(' ').ToList();
            for (int i = 0; i <= 4; i++)
            {
                //adding new cards to our card list
                this.Cards.Add(new Card(tempList[i]));
            }
        }

        //new functions go here
        public bool IsFlush()
        {
            //how to select just one property
            //and get only unique (distinct) values

            //selects only the suits for our cards takes only
            //distinct values and counts them,
            //if only one suit it's a flush
            return this.Cards.Select(x => x.Suit).Distinct().Count() == 1;
        }

        public bool HasPair()
        {
            //selects only ranks for cards and if only 4 values there is at least
            //one pair in the hand
            return this.Cards.Select(x => x.Rank).Distinct().Count() == 4;
        }

        public bool TwoPair()
        {
            //selects cards if they are a pair
            return this.Cards.Select(x => x.Rank).Distinct().Count() == 3;
        }

        public bool FullHouse()
        {
            //if there is a three of a kind and a pair it's a full house
            if (ThreeOfAKind() && HasPair())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Straight()
        {
            //select the rank of our hand and order it by said rank
            //create a string of all ranks and see if cards are in this string
            string temp = string.Join("", this.Cards.OrderBy(x=>x.Rank).Select(x=>x.Rank));
            string temp1 = "234567891011121314";
            return temp1.Contains(temp);
        }

        public bool StraightFlush()
        {
            //if straight and flush it's a straight flush
            if (IsFlush() && Straight())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ThreeOfAKind()
        {
            //if three cards have the same rank it's three of a kind
            var tmp = this.Cards.GroupBy(x => x.Rank).Select(x => new {Rank = x.Key, Count = x.Count()}).OrderByDescending(x => x.Count);

            return tmp.First().Count == 3;
        }

        public bool FourOfAKind()
        {
            //if there are four cards of the same rank it's four of a kind
            return this.Cards.Select(x => x.Rank).Distinct().Count() == 2;
        }

        public bool RoyalFlush()
        {
            //same as straight flush but they have to be a 10 and face cards
            string temp = string.Join("", this.Cards.OrderBy(x => x.Rank).Select(x => x.Rank));
            string temp1 = "1011121314";
            if (IsFlush() && temp.Contains(temp1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HighCard()
        {
            //if none of the other hands possible high card is only option
            if (!IsFlush() && !HasPair() && !TwoPair() && !FullHouse() && !Straight() && !StraightFlush() && !ThreeOfAKind() && !FourOfAKind() && !RoyalFlush())
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
