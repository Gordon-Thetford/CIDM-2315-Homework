namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        
        // Question 1
        Console.WriteLine("Input 2 numbers");
        int x = Convert.ToInt16(Console.ReadLine());
        int y = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Largest number is " + LargestNumber(x, y));

        // Question 2
        Console.WriteLine("Input a number");
        int z = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("...and a shape- either 'left' or 'right'");
        string shape = Console.ReadLine();
        Console.WriteLine($"N is: {z}; shape is {shape}");
        Triangle(z, shape);

    }


    static int LargestNumber(int x, int y)
    {
        if(x > y)
        {
            return x;
        } else {
            return y;
        }
    }

    static void Triangle(int z, string shape)
    {
        if(shape == "left") 
        {
            for(int row = 0; row < z; row ++)
            {
                for(int col = 0; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        } else if(shape == "right")
        {
            for(int row = 0; row < z; row ++)
            {
                for(int space = z-1-row; space > 0; space--)
                {
                    Console.Write(" ");
                }
                for(int ast = -1; ast < row; ast++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        } else {
            Console.WriteLine("Error! Please try again.");
        }
    }
}


