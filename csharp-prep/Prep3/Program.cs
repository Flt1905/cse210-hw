using System;
using System.Collections.Concurrent;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        

       
        
        Console.WriteLine($"What is the magic number ? {number}");

        int guessedNumber= -1;
         while (number!= guessedNumber){
        Console.WriteLine("What is your guess ?");
       string inputFromUser= Console.ReadLine();
        guessedNumber = int.Parse(inputFromUser);
       
       if (number < guessedNumber)
        {Console.WriteLine("Lower");}
       else if (number > guessedNumber) {Console.WriteLine("Higher");}
         
         else 
            {Console.WriteLine("Congratulations, that is Correct");}
         }

    }     
}