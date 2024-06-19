using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
         string playAgain = "yes";
      
      while(playAgain.ToLower() == "yes")
      {
      Random randomGenerator = new Random();
      int magicNumber = randomGenerator.Next(1, 51);
      
      int guess = -1;
      int guessCount = 0;
    //   string playAgain;
      
      while(guess != magicNumber)
      {
          Console.Write("What is your guess? ");
          guess = int.Parse(Console.ReadLine());
          
          // Guess Counter
          guessCount++;
          
          // Conditional statement 
          if(magicNumber > guess)
          {
              Console.WriteLine("Higher");
          }
          else if(magicNumber < guess)
          {
              Console.WriteLine("Lower");
          }
          else
          {
              Console.WriteLine("\n********************************");
              Console.WriteLine($"Guess is correct! {magicNumber}");
              Console.WriteLine($"You guess {guessCount} times!");
              Console.Write("********************************");
          }
      }
      
      Console.Write("\n\nDo you want to play again? yes/no: ");
      playAgain = Console.ReadLine();
      
      }
          Console.WriteLine("\nThanks for playing! ");
    }
}