using System;
class Program
{
    static double Forecast(double amount, double rate, int years)
    {
        if (years == 0)
        {
            return amount;
        }
        return Forecast(amount * (1 + rate), rate, years - 1);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter Initial Amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Growth Rate (Example 0.10): ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Number of Years: ");
        int years = Convert.ToInt32(Console.ReadLine());
        double futureValue = Forecast(amount, rate, years);

        Console.WriteLine("Future Value = " + futureValue);
    }
}

