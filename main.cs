using System;

class Program
{
    public static void Main(string[] args)
    {
        int hours;
        int rate;
        double pay;
        double tax;
        double TAX_RATE;
  
        Console.WriteLine("Salary Program with Csharp");
        Console.WriteLine("");

        Console.Write("Numbers of hours worked: ");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("hourly rate: $ ");
        rate = Convert.ToInt32(Console.ReadLine());
  
        TAX_RATE = 0.18;
        pay = (hours * rate) * (1.00 - TAX_RATE);
        tax = (hours * rate) * TAX_RATE;
    
        Console.WriteLine("");
        Console.WriteLine("The pay is: " + pay.ToString("0.00") + ". ");
  
        pay.ToString("0.00"); // returns "0.50"  when decimalVar == 0.5m
 
        Console.WriteLine("The tax is: " + tax.ToString("0.00") + ". ");

        tax.ToString("0.00"); // returns "0.50"  when decimalVar == 0.5m

        Console.WriteLine("\nDone.");
    }
}