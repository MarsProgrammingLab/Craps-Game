using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrapsGame
{
    public class craps
    {
        static void Main(string[] args)
        {
            Title();
            Play();
        }

        static void Title()
        {
            WriteLine("******************");
            WriteLine("Lets play Craps!");
            WriteLine("******************\n");
            WriteLine("To play the game, a player rolls a pair of dice (2 die).");
            WriteLine("After the dice come to rest, the sum of the faces of the 2 die is calculated.");
            WriteLine("If the sum is 7 or 11 on the first throw, the player wins and the game is over.");
            WriteLine("If the sum is 2, 3, or 12 on the first throw, the player loses and the game is over.");
            WriteLine("If the sum is 4, 5, 6, 8, 9, or 10 on the first throw, then that sum is known as the player’s “point”. ");
            WriteLine("To win, he must keep throwing the dice until he/she “makes his point”, that is, the sum of the dice is equal to his point.");
            WriteLine("The player loses if he throws a 7 before making his point. In either case, the game is over.\n");
            WriteLine("The player will be assigned 100 chips before beginning to play the game.");
            WriteLine("Each time the game is played, the user will be asked to make a wager.");
            WriteLine("If the player wins the game, s(he) receives double his wager.");
            WriteLine("If s(he) loses, then the wager is lost. ");
            WriteLine("The game is played until the player no longer wishes to play or until the chips are all used.At this time, display the total number of chips remaining.\n");
        }
        
        static void Play()
        {
            string playAgain;
            string userName;
            int point = 0;
            int chips = 100;
            int wager = 0;
            // For random number generation after each dice roll
            Random rnd = new Random();

            // Retrieve player name
            Console.Write("Please enter player name to play: \n");
            userName = ReadLine();
            WriteLine("Welcome " + userName + "! " + "Let's begin.\n");

            WriteLine("Roll your dice!\n");
            
            // Generate random numbers for dice rolls 
            int die = rnd.Next(1, 6);
            WriteLine("Dice one result: " + die);
            
            int die2 = rnd.Next(1, 6);
            WriteLine("Dice two result: " + die2);
            
            // Retrieve sum of both dice
            int sum = die + die2;
            WriteLine("Sum of both dice: \n" + sum);

            // if-elseIf-else conditional statements 
            // to determine if player wins or loses
            if (sum == 7 || sum == 11)
            {
                WriteLine("Congratulations! You won!");
                wager += chips * 2;
                WriteLine("Current wager: " + wager);               
            }
            else if (sum == 2 || sum == 3 || sum == 12)
            {
                WriteLine("You lost. Better luck next time!");
                wager = 0;
                WriteLine("Current wager: " + wager);
            }
            else
            { 
                WriteLine("You rolled " + sum + ".\n");
                point = sum;

                // Generate random numbers for dice rolls 
                int die3 = rnd.Next(1, 6);
                WriteLine("Dice three result: " + die3);

                int die4 = rnd.Next(1, 6);
                WriteLine("Dice four result: " + die4);

                // Retrieve sum of both dice
                int sumTwo = die + die2;
                WriteLine("Sum of both dice: " + sumTwo);

                if(sumTwo == 7)
                {
                    WriteLine("You lost. Game over.");
                    wager = 0;
                    WriteLine("Current wager: " + wager);

                }
                else if(sumTwo == point)
                {
                    WriteLine("Congratulations! You matched your point and won!");
                    wager += chips * 2;
                    WriteLine("Current wager: " + wager);
                }
            }
                          
            WriteLine("Would you like to play again? y/n: ");
            playAgain = ReadLine();

            // Player can continue playing when entering "y"
            while (playAgain == "y")
            {
                Play();
            }
            // Player can end game when entering "n"
            if (playAgain == "n")
            {
                System.Environment.Exit(0);
            }

        }
    }
}
