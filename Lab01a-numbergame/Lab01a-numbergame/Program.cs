using System;

namespace Lab01a_numbergame //name of program
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Numbers Game");//title
         

          try
        {
          //StartSequence(); //name of method-does not exist in the current context
        }
          catch (Exception e) 
        {
          Console.WriteLine("Something wrong");
          Console.WriteLine(e.Message);
        }
          finally
        {
          Console.WriteLine("Finish");
        }

          Console.ReadLine();
        }
           
    }
}

