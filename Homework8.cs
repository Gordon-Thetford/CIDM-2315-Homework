namespace Homework8;

class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) 
    {
        // // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = 
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


        // Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3)
        {
            Console.Write(num +" ");
        }
    }




    // **Compete the following methods, then run the program to check outputs**
    // Q1: calculate the sum of elements in a given int_array (4 points)
    public static void ArraySum(int[] int_array)
    {
        int num_Sum = 0;
        foreach(int itemA in int_array)
        {
            num_Sum += itemA;
        }
        Console.WriteLine($"The Sum of int_array is: {num_Sum}");
    }


    // Q2.1: given a 2d array, print all the odd elements (2 points)
    public static void PrintAllOddNumber(int[ , ] array_2d)
    {
       for(int rowQ2_1 = 0; rowQ2_1 < 3; rowQ2_1++)
       {
            for(int colQ2_1 = 0; colQ2_1 < 3; colQ2_1++)
            {
                int itemB = array_2d[rowQ2_1, colQ2_1];
                if(itemB % 2 == 1)
                {
                    Console.Write(itemB + " ");
                }
            }
       }
    }


    
    // //Q2.2: given a 2d array, return the sum of all elements (2 points)
    public static int ElementSum(int[ , ] array_2d)
    { 
        int itemC = 0;
        int num_Sum_Q2 = 0;

        for(int row = 0; row < 3; row++)
       {
            for(int col = 0; col < 3; col++)
            {
                itemC = array_2d[row, col];
                num_Sum_Q2 += itemC;
            }
       }
        return num_Sum_Q2;
    }


    // // Q2.3: given a 2d array, double its element values and return it (2 points)
    public static int[ , ] DoubleArray(int[ , ] array_2d)
    {
        int[,] Q2_3 = new int[3,3];

        for(int row = 0; row < 3; row++)
        {
            for(int col = 0; col < 3; col++)
            {
                Q2_3[row, col] = array_2d[row, col] * 2;
            }
        }
        return Q2_3;
    }  
}

