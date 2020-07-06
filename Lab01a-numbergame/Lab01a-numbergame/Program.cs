using System;

namespace Lab01a_numbergame //name of program-main method
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

    static void StartSequence()//name of program
    {
      Console.WriteLine("Enter a number greater than zero");

      try
      {
        string firstUserNumberAsString = Console.ReadLine(); // Users number as string
           
        int firstUserNumberAsInt = Convert.ToInt32(firstUserNumberAsString);// Converting users number  to integer 
                
        int[] userArray = new int[firstUserNumberAsInt];  // userArray of length of users number


        int[] populatedArray = Populate(userArray);   //  variable stored populated int array 

                
        int sumOfArray = GetSum(populatedArray);  // Sum of numbers stored in array of users  numbers 

        
        int product = GetProduct(populatedArray, sumOfArray);  // Product of sum stored to array elements multiplied by
                                                                // number at array index picked by user

        
        decimal quotient = GetQuotient(product); // Store quotient of product divided by a divisor input by user 


        // All the operations output results
        Console.WriteLine($"Length of your array is: {firstUserNumberAsString}");
        Console.WriteLine($"Numbers in the array are: " + "{0}", string.Join(",", populatedArray));
        Console.WriteLine($"Sum of the array is: {sumOfArray}");
        int extractedFactor = product / sumOfArray;
        Console.WriteLine($"{sumOfArray} * {extractedFactor} = {product}");
        decimal extractedDivisor = Convert.ToDecimal(product) / quotient;
        Console.WriteLine($"{product} / {extractedDivisor} = {quotient}");
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (OverflowException e)
    {
        Console.WriteLine(e.Message);
    }
}
