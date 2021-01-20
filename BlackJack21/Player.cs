using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack21
{
    public class Player
    {
        private int numberofcard;
        private int valueofcard;
        public int[] cardsInPlayerHand;
        private int cardtype;
        Random random;
        private string msg;
        private int playerID;
        private int iDealerNumbCards_2;
        private string[] sPlayerEndResult;

        public int Numberofcard 
        { 
            get {return numberofcard; 
        }
    
        }
        public int Valueofcard 
        { 
            get { return valueofcard; } 
        
        }
        public string Msg 
        {
            
            get { return msg; } 
        }

        public Player(int numOfplayer , int numOfPlayerCards)
        {
            random = new Random();
            numberofcard = numOfPlayerCards;
            cardsInPlayerHand = new int[numberofcard];
            playerID = numOfplayer;
            sPlayerEndResult = new string[playerID];


        }
        // Generating card in PLayers  Hand //
        private string GetCardTypeValue(int index) {
            var cardsInPlayerHand = string.Empty;
            cardtype = random.Next(1, 4);
            switch (cardtype)
            {
                case 1:
                    cardsInPlayerHand = $"{index} Spades";
                    break;
                case 2:
                    cardsInPlayerHand = $"{index} Heart";
                    break;
                case 3:
                    cardsInPlayerHand = $"{index} Clubs";
                    break;
                case 4:
                    cardsInPlayerHand = $"{index} Diamond";
                    break;
                default:
                    break;
            }
            return cardsInPlayerHand;
        }
        // Generating cards for Player //
        public int[]  Cards(int  dealerNumber, int dealerCardValues)
        {
            iDealerNumbCards_2 = dealerNumber;
            valueofcard = 0;
            for (int i = 0; i < numberofcard; i++)
            {
              var  cardValue = random.Next(1, 11);
                cardsInPlayerHand[i] = cardValue;
              var assignedCard = GetCardTypeValue(cardValue);
               Console.WriteLine( $" {assignedCard}");
            }
            return cardsInPlayerHand;
        }
        // Calculates the sum of total values of cards (Gets Value Of Cards In Hand)//
       public int GetCardsSum(int[] values) {
            var sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }
        //Checking of 1 and 11 in the sum of cards //
        public int[] CheckForOneOrEleven(int[] values) {
            var sum = GetCardsSum(values);
            if (sum > 21)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i].Equals(11))
                    {
                        values[i] = 1;
                    }
                }
            }
            else {
                for (int i = 0; i < values.Length; i++)
                {
                    if (values[i].Equals(1))
                    {
                        values[i] = 11;
                        if (!GetCardsSum(values).Equals(21))
                            values[i] = 1;
                    }
                }
            }
          
            return values;
        }

        public string PrintResult(int iCount_2)
        {
            if (numberofcard == 5 || numberofcard == 4 || numberofcard == 3 || numberofcard ==  2)
                if (valueofcard < 21)

                    msg = " Beats dealer."; 
            
                else
                    msg = " Loses.";

            if (numberofcard >= iDealerNumbCards_2)
                if (valueofcard <= 21)
                    msg = " Beats dealer.";
                else
                    msg = " Loses.";

            return  iCount_2 + msg;
        }
    }
    }

        
