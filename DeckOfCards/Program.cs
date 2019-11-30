using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shuffle Deck!");
            Deck myDeck = new Deck();
            Players myPlayer = new Players("Dan");
            myDeck.shuffle();
            Console.WriteLine("this should print out the deck");
            Console.WriteLine(myDeck);
            myPlayer.Draw(myDeck);
            myPlayer.Draw(myDeck);
            myPlayer.Draw(myDeck);
            myPlayer.Discard(1);
            Console.WriteLine(myPlayer.hand);
            Console.WriteLine("this should print out thehand");



        }
    }
}
