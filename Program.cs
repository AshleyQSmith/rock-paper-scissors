using System;

namespace csharp_rockpaperscissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      System.Console.WriteLine("Want to play Rock Paper Scissors? Y/N");
      string userInput = Console.ReadLine();
      bool playing = userInput.ToLower() == "y";
      Random random = new Random();
      int compChoice = random.Next(1, 3);
      // 1 = rock
      // 2 = paper
      // 3 = scissors




      while (playing)
      {

        System.Console.WriteLine("Type your guess: rock, paper, or scissors");
        string userGuess = Console.ReadLine();

        if (userGuess.ToLower() == "rock")
        {
          if (compChoice == 1)
          {
            System.Console.WriteLine("You Tied!");
          }
          if (compChoice == 2)
          {
            System.Console.WriteLine("You Lost!");
          }
          else if (compChoice == 3)
          {
            System.Console.WriteLine("You Win!");
          }
        }

        if (userGuess.ToLower() == "paper")
        {
          if (compChoice == 1)
          {
            System.Console.WriteLine("You Win!");
          }
          if (compChoice == 2)
          {
            System.Console.WriteLine("You Tied!");
          }
          else if (compChoice == 3)
          {
            System.Console.WriteLine("You Lost!");
          }
        }

        if (userGuess.ToLower() == "scissors")
        {
          if (compChoice == 1)
          {
            System.Console.WriteLine("You Lost!");
          }
          if (compChoice == 2)
          {
            System.Console.WriteLine("You Win!");
          }
          else if (compChoice == 3)
          {
            System.Console.WriteLine("You Tied!");
          }
        }

        // if (userGuess.ToLower() != "rock" || userGuess.ToLower() != "paper" || userGuess.ToLower() != "scissors")
        // {
        //   System.Console.WriteLine("Not a valid guess");
        //   continue;
        // }

        System.Console.WriteLine("Do you want to play again? Y/N");
        string continueGame = Console.ReadLine();
        if (continueGame.ToLower() == "y")
        {
          compChoice = random.Next(1, 3);
        }
        else
        {
          System.Console.WriteLine("Thanks for playing!");
          playing = false;
        }
        continue;






        System.Console.WriteLine("Thanks for Playing!");


      }





    }
  }
}
