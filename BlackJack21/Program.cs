using System;

namespace BlackJack21
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dealer dealer = new Dealer();
            Random rnd = new Random();
            Dealer TheDealer = new Dealer();

            int iPlayerNumb = rnd.Next(2,5);


            // Displaying Dealers Cards//
            Console.WriteLine("\t\t");
            Console.WriteLine("---------------------------------Dealers Cards--------------------------------" + "\n");

            dealer.GetCardsValue();
            
            // Players In There Game//
            var playerTotal = 0;
            Player ThePlayer;
            // Loop through players & Displaying Results //
            for (int i = 0; i < iPlayerNumb; i++)
            {
                var numberOfCardsPerPlayer = rnd.Next(2, 5);
                ThePlayer = new Player(iPlayerNumb, numberOfCardsPerPlayer);
                int[] cardsInPlayerHand = new int[numberOfCardsPerPlayer];
                //Displaying Players 
                Console.WriteLine($"-------------------------- Player {i + 1}'s cards: --------------------------");
                Console.Write("");
                cardsInPlayerHand =  ThePlayer.Cards(TheDealer.Numberofcard, TheDealer.Valueofcard);
                var newCards = ThePlayer.CheckForOneOrEleven(cardsInPlayerHand);
                cardsInPlayerHand = newCards;
                var sum = ThePlayer.GetCardsSum(cardsInPlayerHand);
                Console.WriteLine($"{i+1} \n Value of Cards: = {ThePlayer.PrintResult(sum)}");
                Console.WriteLine("-----------------------------------------------------------------------------" + "\n");
                Console.WriteLine("\n");

            }

            Console.ReadKey();

            //End Of BlackJack //

        }
    }

}
