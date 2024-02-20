namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Q1 Method Call and Print
        int Q1num = LargestOfTwo();
        Console.WriteLine("The largest number is: " + Q1num);

        // Q2 Method Call and Print
        int Q2num = LargestOfFour();
        Console.WriteLine("The largest number is: " + Q2num);

        // Q3 Method Call
        CreateAccount();

    }
    // Q3 Method 1
    static bool CheckAge(int birth_year)
    {
        int current_year = 2024;
        int age = current_year - birth_year;
        if(age >= 18) {
            return true;
        } else {
            return false;
        }
    }

    // Q3 Method 2
    static void CreateAccount()
    {
        Console.WriteLine("Please input a username");
        string username = Console.ReadLine();

        Console.WriteLine("Please input a password");
        string password1 = Console.ReadLine();

        Console.WriteLine("Please input the password again");
        string password2 = Console.ReadLine();

        Console.WriteLine("Please enter your birth year");
        int birth_year = Convert.ToInt16(Console.ReadLine());

        if(CheckAge(birth_year)) {
            if(password1 == password2) {
                Console.WriteLine("Account is created successfully");
            } else {
                Console.WriteLine("Wrong Password");
            }
        } else {
            Console.WriteLine("Could not create an account");
        }
    }

    // Q1 Method
    static int LargestOfTwo()
    {
        Console.WriteLine("Please input two integers");
        int num1 = Convert.ToInt16(Console.ReadLine());
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {num1}; b = {num2}");

        if(num1 > num2) {
            return num1;
        } else {
            return num2;
        }
    }

    //Q2 Method
    static int LargestOfFour()
    {
        int max1 = LargestOfTwo();
        int max2 = LargestOfTwo();

        if(max1 > max2) {
            return max1;
        } else {
            return max2;
        }
    }


}
