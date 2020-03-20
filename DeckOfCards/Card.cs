namespace DeckOfCards
{
    public class Card
    
    {
        public string stringVal
        {
            get 
            {
                if (val > 1 && val < 11)
                {
                    return val.ToString();
                }
                else if (val == 1)
                {
                    return "Ace";
                }
                else if (val == 11)
                {
                    return "Jack";
                }
                else if (val == 12)
                {
                    return "Queen";
                }
                else if (val == 13)
                {
                    return "King";
                }
                else
                {
                    return "Joker";
                }
            }
        }

        public string Suit;

        public int Val;

        public Card(int val, string suit)
        {
            Val = val;
            Suit = suit;
        }
    }
}
