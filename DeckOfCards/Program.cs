using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play Cards!");
            Console.WriteLine("Let's play cards!");
            Deck myDeck = new Deck();
            Players Dan = new Players("Dan");
            myDeck.Shuffle();
            Console.WriteLine(myDeck.cards.Count);
            Dan.Draw(myDeck);
            Console.WriteLine(Dan.Hand.Count);
            Dan.Draw(myDeck);
            Console.WriteLine(Dan.Hand.Count);
            Dan.Draw(myDeck);
            Dan.Discard(1);
            Console.WriteLine(Dan.Hand.Count);
            myDeck.Shuffle();
            Console.WriteLine(myDeck.cards.Count);
            Console.WriteLine(Dan.Hand[0].Val);
            Console.WriteLine("This should print out the hand");
        }
    }
}
