using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Players
    {
        public string Name;
        public List<Card> Hand = new List<Card>();

        public Players (string n)
        {
            Name = name;
        }

        public void Draw(Deck cards)
        {
            Console.WriteLine("Drawing a Card");
            Hand.Add(cards.Deal());
        }

        public Card Discard(int indexNum)
        {
            Card temp = Hand[indexNum];
            Hand.RemoveAt(indexNum);
            return temp;
        }
    }
}
