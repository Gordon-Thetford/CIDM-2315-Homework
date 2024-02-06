namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        
        // Question 1
        Console.WriteLine("Input an integer");
        int num = Convert.ToInt16(Console.ReadLine());
        bool isPrime = true;

        for (int i = 2; i < num / 2; i++) {
            if (num % i == 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            Console.WriteLine("N is prime");
        } else {
            Console.WriteLine("N is non-prime");
        } 
        

        // Question 2
        Console.WriteLine("Input an integer");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int i = 1; i <= N; i++)
        {
            for(int g = 1; g <= N; g++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        
        // Question 3
        Console.WriteLine("Input an integer");
        int rows = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row < rows; row++)
        {
            for(int col = 0; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
