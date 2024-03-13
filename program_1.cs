using System;
namespace Basics
{
    internal class Program
    {
       public static void Main(string[] args)
    {

      Game(12, 5);

    }
    
    
    
    //Functions
    //=================================================================================================
    //Parrot
    public static void Parrot(int count, string str)
    {
      str = "A huge pleasure to be able to see that we are finally using loops and not recusivity...!"; // Maybe we could use a Console.Read();
      count = 5; //No number will be large enough...!
      int meter = 0;
      while (meter < count)
      {
        Console.WriteLine(str);
        meter++;
      }
    }
    
    
    
    
    
    
    
    
    //=================================================================================================
    //Introduction
    public static void Introduction(string name, uint age, string city, string work)
    {
      name = "William";
      age = 32;
      city = "Arcachon";
      work = "L'immobilier";
      Console.WriteLine("Hello, my name is " + name + ", I am " + age + ", I live in " + city + " and I work in " + work);
    }
    
    
    
    
    
    
    
    
    //=================================================================================================
   //// Tower
    public static void Ground()
    {
      Console.WriteLine("|     _     |");
      Console.WriteLine("|    | |    |");
      Console.WriteLine("|____|_|____|");
    }

    public static void Floor(int nb)
    {
      int meter = 0;
      while (meter < nb)
      {
        Console.WriteLine("|  _     _  |");
        Console.WriteLine("| |o|   |o| |");
        Console.WriteLine("| |_|   |_| |");
        meter++;
      }
    }

    public static void Roof()
    {
      Console.WriteLine(" ___________");
      Console.WriteLine("|           |");
      }
    
    
    
    
    
    
    
    
    //=================================================================================================
    //More or Less
    //CheckNumber
    public static bool CheckNumber(int input, int number)
    {
      Console.WriteLine("\n====== Hello, Welcome to the More or Less Game !! =======\n");

      input = 0;
      
      while (input != number)
      {
        Console.ForegroundColor = ConsoleColor.Black;
        
        Console.WriteLine("Please, input a number: ");
        string inputStr = Console.ReadLine();
        input =  int.Parse(inputStr);

        
        if (input < number)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("The correct number is superior to: {0}\n", input);
          
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("The correct number is inferior to : {0}\n", input);
        }
      }
     
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("Congratulation, the number was: {0}\n", input);
      return true;
      
    }
    
    
    
    
    
    
    
    
    
    //=================================================================================================
    //Game
    public static bool Game(int number, int tries)
    {
      
      Console.WriteLine("\n====== Hello, Welcome to the More or Less Game !! =======\n");

      int input = 0;
      
      while (input != number && tries != 0)
      {
        Console.ForegroundColor = ConsoleColor.Black;
        
        Console.WriteLine("Please, input a number: ");
        string inputStr = Console.ReadLine();
        input =  int.Parse(inputStr);

        
        if (input < number)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("The correct number is superior to: {0}\n", input);
          tries--;
          Console.ForegroundColor = ConsoleColor.Black;
          Console.WriteLine("{0} tries left: ", tries);
          
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("The correct number is inferior to : {0}\n", input);
          tries--;
          Console.ForegroundColor = ConsoleColor.Black;
          Console.WriteLine("{0} tries left: ", tries);
          
        }
      }
      
      if (tries == 0)
      {
        Console.WriteLine("The correct number was: {0}", number);
        return false;
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Congratulation, the number was: {0}\n", input);
        return true;
      }
    }
    }
}