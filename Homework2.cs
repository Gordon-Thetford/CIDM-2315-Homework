namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        
         //Question 1
        Console.WriteLine("Input your letter grade");
        string letterGrade = Console.ReadLine();

        switch (letterGrade)
        {
            case "A":
                Console.WriteLine("4");
                break;
            
            case "B":
                Console.WriteLine("3");
                break;

            case "C":
                Console.WriteLine("2");
                break;

            case "D":
                Console.WriteLine("1");
                break;
            
            case "F":
                Console.WriteLine("0");
                break;

            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }
        
        //Question 2
        Console.WriteLine("Please input the first number");
        string firstNumStr = Console.ReadLine();
        int firstNum = Convert.ToInt16(firstNumStr);

        Console.WriteLine("Please input the second number");
        string secondNumStr = Console.ReadLine();
        int secondNum = Convert.ToInt16(secondNumStr);

        Console.WriteLine("Please input the third number");
        string thirdNumStr = Console.ReadLine();
        int thirdNum = Convert.ToInt16(thirdNumStr);

        if(firstNum > secondNum)
        {
            if(secondNum > thirdNum)
            {
                Console.WriteLine("The smallest value is " + thirdNum);
            } else {
                Console.WriteLine("The smallest value is " + secondNum);
            }
        } else {
            if(firstNum > thirdNum){
                Console.WriteLine("The smallest value is " + thirdNum);
            } else {
                Console.WriteLine("The smallest value is " + firstNum);
            }
        }

        //Question 3
        Console.WriteLine("Input a year to see if it is a leap year.");
        string yearStr = Console.ReadLine();
        int year = Convert.ToInt16(yearStr);

        if(year % 400 == 0)
        {
            Console.WriteLine($"{year}" + " is a leap year!");
        } else if(year % 100 == 0)
        {
            Console.WriteLine($"{year}" + " is not a leap year!");
        } else if(year % 4 == 0)
        {
            Console.WriteLine($"{year}" + " is a leap year!");
        } else {
            Console.WriteLine($"{year}" + " is not a leap year!");
        }

    }
}
