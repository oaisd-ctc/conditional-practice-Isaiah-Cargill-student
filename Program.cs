
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
         CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
         CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
         CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }
public static void CheckForPositiveNegativeZero(int number)
{
if (number < 0)
{
 Console.WriteLine(" your number is negative");
}

else if (number > 0) 
{
    Console.WriteLine(" your number is positive");
}

else if (number == 0)
{
    Console.WriteLine(" your number is zero");
}

}
public static void FindMinimum(int num1, int num2, int num3)
{
    if (num1 < num2 && num1 < num3 )
    {
      Console.WriteLine(" The minimum value is" + num1);
    }

    else if (num2 < num1 && num2 < num3)
    {
        Console.WriteLine(" The minimum value is" + num2);
    }

    else if (num3 <num2 && num3 < num1)
    {
         Console.WriteLine(" The minimum value is" + num3);
    }
}

public static void FindMaximum(int num1, int num2, int num3)
{
    if (num1 > num2 && num1 > num3)
    {
        Console.WriteLine(" the maximum value is" + num1);
    }
    
    else if (num2 > num1 && num2 > num3)
    {
         Console.WriteLine(" the maximum value is" + num2);
    }
    else if (num3 > num2 && num3 > num1)
    {
        Console.WriteLine( " the maximum value is" + num3);
    }
}  
 public static void IsDivisibleBy5(int number)
 {
    if(number % 5==0)
    {
 Console.WriteLine(number + " is not divisible by 5");
    }

    else
    {
     Console.WriteLine(number + " is divisible by 5");
    }
 }

 public static void CheckEvenOrOdd(int number)
 {
    if(number % 2==1)
    {
     Console.WriteLine(number + " is an odd number");
    }

    else if(number % 2==0)
    {
        Console.WriteLine(number + " is an even number");
    }
 }

  public static void CheckVowelOrConsonant(char letter)
  {
    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
    {
      Console.WriteLine(letter + " is a vowel.");
    }

    else{
        Console.WriteLine(letter + " is a consonant");
    }
   
  }
    

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

    public static void DisplayDayOfWeek(int dayCode) 
    {
        if(dayCode == 0)
        {
            Console.WriteLine(dayCode + " - sunday");
        }
        
        else if(dayCode == 1)
        {
            Console.WriteLine(dayCode + " - monday");
        }
          
          else if(dayCode == 2)
        {
            Console.WriteLine(dayCode + " - tuesday");
        }

        else if(dayCode == 3)
        {
            Console.WriteLine(dayCode + " - wednesday");
        }

        else if(dayCode == 4)
        {
            Console.WriteLine(dayCode + " - thursday");
        }

          else if(dayCode == 5)
        {
            Console.WriteLine(dayCode + " - friday");
        }
          
          else if(dayCode == 6)
        {
            Console.WriteLine(dayCode + " - saturday");
        }
          
          else 
        {
            Console.WriteLine(dayCode + " - invalid");
        }
    }
      
    
    
}
