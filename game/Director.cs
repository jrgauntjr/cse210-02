using System;
using System.Collections.Generic;

namespace Lab02.Game
{
    public class Director
    {
        bool isPlaying = true;
        int score = 300;
        int card1 = 0;
        int card2 = 0;
        string choice;
        public Director()
        {
            Card card = new Card();
            card.GetCard();
            card1 = card.value;
        }
        public void StartGame()
        {
            while (isPlaying==true)
                {                    
                    GetInputs();
                    DoUpdates();
                    DoOutputs();
                }
        }
        public void GetInputs()
        {
            //______________________________________________________________________
            //GET INPUT FROM PLAYER_________________________________________________
            Console.WriteLine(card1);
            Console.Write("higher or lower? [h/l]: ");
            choice = Console.ReadLine();
        }
        public void DoUpdates()
        {
            //______________________________________________________________________
            //CREATE SECOND CARD____________________________________________________
            Card card = new Card();
            card.GetCard();
            card2 = card.value;
        }
        public void DoOutputs()
        {
            //____________________________________________________________________________
            //GATHER RESULTS AND DECIDE ON POINTS_________________________________________
            if (choice == "h" && card1 < card2||choice == "l" &&card1 > card2)
                score = score + 100;
            else if(choice == "h" && card1 >= card2||choice == "l" &&card1 <= card2)
                score = score - 75;
            Console.WriteLine($"The card was {card2}");
            Console.WriteLine($"Your Score is {score}");
            //____________________________________________________________________________________________
            //REPLACE CARD TO COMPARE A THE NEW ONE IN CASE GAME IS PLAYED AGAIN_________________________
            card1 = card2;
            //______________________________________________________________________________________
            //GAME VERIFIES IF PLAYER LOST OR WANTS TO QUIT_________________________________________
            if (score <=0)
            {
                Console.WriteLine($"Your total score was {score}, thanks for playing!");
                isPlaying = false;
                return;
            }
                Console.Write("Another round?[y/n] ");
                string Continue = Console.ReadLine();
            if (Continue == "n")
            {
                Console.WriteLine($"Your total score is {score}, thanks for playing!-------------------------------------------------------------------------------------------");
                isPlaying = false;
            }
        }
    }
}