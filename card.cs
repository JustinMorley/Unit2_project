using System;

namespace HiloGame
{
    public class Card
    {
        public int CardNumber = 0;

        public Card()
        {}


        public int CardGenerate()
        {
            Random randomCard = new Random();
            CardNumber = randomCard.Next(1,14);
            return CardNumber;
        }
    

    }
}