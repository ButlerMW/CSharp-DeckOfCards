namespace DeckOfCards
{
    public class Card
    
    {
        // public string[] stringVal = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        // public string[] suit = new string[] {"Clubs","Spades","Hearts","Diamons"};
        // // public int[] val = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13}; // might not need this exactly??
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

        public string suit;

        public int val;

        public Card(int v, string s)
        {
            val = v;
            suit = s;
        }
    }
}