using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of cards to pick");

            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }
    }

    class CardPicker
    {

        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        public static string RandomValue()
        {
            int value = random.Next(1, 14);

            switch(value)
            {
                case 1:  return "Ace";      break;
                case 11: return "Jack";     break;
                case 12: return "Queen";    break;
                case 13: return "King";     break;
                default: return value.ToString();   break;
            }
        }

        public static string RandomSuit()
        {
            int value = random.Next(1, 5);

            switch(value)
            {
                case 1:
                    return "Spades";
                    break;
                case 2:
                    return "Hearts";
                    break;
                case 3:
                    return "Clubs";
                    break;
                case 4:
                default:
                    return "Diamonds";
                    break;
            }
        }
    }
}
