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
            WriteLine("******************");
        }
        
        static void Play()
        {
            string userName;

            Console.Write("Please enter player name: ");
            userName = ReadLine();
            WriteLine("Welcome " + userName + "! " + "Let's begin.");

        }
    }
}
