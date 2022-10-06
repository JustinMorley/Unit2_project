using System;

namespace HiloGame
{
    public class Director
    {
        Card card = new Card();
        int points = 300;
        string HiLo = "";
        int NewCard = 0;
        int OldCard = 0;
        public bool IsPlaying = true;
        string play = "y";
        public void StartGame()
        {
            NewCard = card.CardGenerate();

            while(IsPlaying)
            {
            turn();
            score();
            playing();
            }
            
        }

        public void turn()
        {
            Console.WriteLine($"Card is: {NewCard}");
            Console.WriteLine("Higher or Lower? (h/l)?");
            HiLo = Console.ReadLine();
            OldCard = NewCard;

            while(NewCard == OldCard){
                NewCard = card.CardGenerate();
            }
            Console.WriteLine($"New card: {NewCard}");
        }

        public void score()
        {
            if(HiLo == "h")
            {
                if(NewCard > OldCard)
                {
                    points = points + 100;
                }
                else if(NewCard < OldCard)
                {
                    points = points - 75;
                }

            }    
            else if(HiLo == "l")
            {
                if(NewCard > OldCard)
                {
                    points = points - 75;
                }
                else if(NewCard < OldCard)
                {
                    points = points + 100;
                }
            }
            Console.WriteLine($"Your score is: {points}");
            if(points <= 0)
            {
                IsPlaying = false;
                Console.WriteLine("You have run out of points!");
            }
        }

        public void playing()
        {   
            if(points > 0)
            {
                Console.WriteLine("Play again? (y/n)");
                play = Console.ReadLine();
                if(play == "n")
                {
                    IsPlaying = false;
                }
            }
                
            
        }

    }
}