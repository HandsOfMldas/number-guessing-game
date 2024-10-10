
//guess a number game 

using System.Security.Cryptography;
using static System.Console;

WriteLine("Hello, let's play a game shall we!! (answer using yes or no)");
String ans = Console.ReadLine();
int guess = 0;
if (ans == "yes")
{
    int x =RandomNumberGenerator.GetInt32(1, 99);
   
    WriteLine("Guess a number: ");
    guess = Convert.ToInt32(Console.ReadLine());
    // ReSharper disable once EmptyForStatement
    for (int i = 0; i < 5 ; i++)
    {
        if (guess < x)
        {
            Console.WriteLine("Guess higher");
            guess = Convert.ToInt32(Console.ReadLine());
        } else if ( guess > x)
        {
            Console.WriteLine("Guess lower");
            guess = Convert.ToInt32(Console.ReadLine());
        }else 
        {
            Console.WriteLine("You win");
            return;
        } 
       
    } 
    Console.WriteLine("You lose the answer is " +x);
}



ReadKey();
