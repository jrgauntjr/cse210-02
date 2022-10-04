using System;
using System.Collections.Generic;

namespace Lab02.Game
{
    public class Card
    {
        public int value = 0;
        public Card()
        {
        }
        public void GetCard()
        {
            Random random = new Random();
            value = random.Next(1, 13);
        }
    }
}