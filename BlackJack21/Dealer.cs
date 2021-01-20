using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack21
{
    public class Dealer
    {
        private int numberofcard;
        private int valueofcard;
        private int[] cardsInDealersHand;
        private int cardInHand;
        private int cards;
        private int cardtype;
        private string msg;
        private int count = 0;
        Random random;
        public int Numberofcard
        {
            get { return numberofcard; }
        }

        public int Valueofcard
        {
            get
            { return valueofcard; }
        }

        public string Msg
        {
            get { return msg; }
        }
        public Dealer()
        {
            random = new Random();
             numberofcard = random.Next(2, 5);
            cardsInDealersHand = new int[numberofcard];

        }


        private string GetCardValue(int index) 
        {
            var cardsInDealersHand = string.Empty;
            cardtype = random.Next(1, 4);
            switch (cardtype)
            {
                case 1:
                    cardsInDealersHand = $"{index} Spades";
                    break;
                case 2:
                    cardsInDealersHand = $"{index} Heart";
                    break;
                case 3:
                    cardsInDealersHand = $"{index} Clubs";
                    break;
                case 4:
                    cardsInDealersHand = $"{index} Diamond";
                    break;
                default:
                    break;
            }
            return cardsInDealersHand;

        }
        public void GetCardsValue()
        {
             
            do {
               
                valueofcard = 0;
                for (int i = 0; i < numberofcard; i++)
                {
                    var cardValue = random.Next(1, 11);
                    cardsInDealersHand[i] = cardValue;
                    var assignedCard = GetCardValue(cardValue);
                    Console.WriteLine($" {assignedCard}");

                }

            } while (valueofcard > 21);

          
            Console.WriteLine($"Value of Cards: {valueofcard}");
            Console.WriteLine("\n");


        }
        public int GetCardsSum(int[] values)
        {
            var sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }
    }
}
    


   

