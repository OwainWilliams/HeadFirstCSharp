using System;

namespace BettingOdds
{
    partial class Program
    {
        

        static void Main(string[] args)
        {
            Random random = new Random();
            Double odds = 0.75;
            Player player = new Player { Name = "The Player", Cash = 100 };


            Console.WriteLine("Welcome to the casino. The odds are " + odds);
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet? ");
                string howMuch = Console.ReadLine();



                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if(pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win " + winnings);
                            player.ReceiveCash(winnings);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck buddy, you lose!");
                        }
                    }
                    
                };

            }
            Console.WriteLine("The house always wins!");
        }
        
    }
}
