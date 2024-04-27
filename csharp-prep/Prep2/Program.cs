using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string fromUser= Console.ReadLine();

       int Grade = int.Parse(fromUser);

       if (Grade >= 90)
       {Console.WriteLine( "A");}
       else if(Grade >= 80)
       {Console.WriteLine( "B");}
       else if(Grade >= 70)
       {Console.WriteLine( "C");}
       else if(Grade >= 60)
       {Console.WriteLine( "D");}
        else if(Grade < 60)
        {Console.WriteLine( "F");}

        
        if (Grade >= 70)
        {Console.WriteLine($"Congratulations ,you have passed the course.");}
        else{Console.WriteLine($"You did not get a passing grade ,Please contact your mentor for more information.");}

    }
}