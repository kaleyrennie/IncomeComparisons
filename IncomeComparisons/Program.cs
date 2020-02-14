using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();


            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;  -- EQUAL
            //bool isWarm = currentTemperature != roomTemperature;  -- NO EQUAL
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            string hourlyRate1 = Console.ReadLine();
            int wage1 = Convert.ToInt32(hourlyRate1);

            Console.WriteLine("Hours worked per week: ");
            string hoursWorked1 = Console.ReadLine();
            int weekly1 = Convert.ToInt32(hoursWorked1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            string hourlyRate2 = Console.ReadLine();
            int wage2 = Convert.ToInt32(hourlyRate2);

            Console.WriteLine("Hours worked per week: ");
            string hoursWorked2 = Console.ReadLine();
            int weekly2 = Convert.ToInt32(hoursWorked2);




            Console.WriteLine("Annual Salary of Person 1");
            int total1 = wage1 * weekly1 * 52;
            Console.WriteLine(total1);

            Console.WriteLine("Annual Salary of Person 1");
            int total2 = wage2 * weekly2 * 52;
            Console.WriteLine(total2);


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool moreIncome = total1 > total2;
            Console.WriteLine(moreIncome);
            Console.ReadLine();






            //int roomTemperature = 70;
            //int currentTemperature = 70;

            //bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;  -- EQUAL
            //bool isWarm = currentTemperature != roomTemperature;  -- NO EQUAL
            //Console.WriteLine(isWarm);
            //Console.ReadLine();







        }
    }
}

