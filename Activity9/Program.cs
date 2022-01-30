
using System;

public class methods
{
   
    public static void showMeters(int numMillimeters)
    {
        Console.WriteLine(numMillimeters / (double)1000);
    }

    //two int and displays their sum.
    public static void showSum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }

    //five doubles and returns their average.
    public static double average(double n1, double n2, double n3, double n4, double n5)
    {
        double avg = (n1+n2+n3+n4+n5) / 5;
        return avg;
    }

    //returns the sum of two randomly generated integers.
    public static double randomSum()
    {
        Random random = new Random();
        int num1 = random.Next(0, 100);
        int num2 = random.Next(0, 100);
        return num1 + num2;
    }

    //three integers and returns true if their sum is divisible by 3, false otherwise.
    public static bool DivisibleBy3(int n1, int n2, int n3)
    {
        int sum = n1+n2+n3;
        return sum%3 == 0;
    }

    // two strings and displays the string that has fewer characters.
    public static void smallString(string small1, string small2)
    {
        if (small1.Length < small2.Length)
        {
            Console.WriteLine(small1);
        }
        else
        {
            Console.WriteLine(small2);
        }
    }

    // array of doubles and returns the largest value in the array.
    public static int findMaxElement(int[] arr)
    {
        
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    //generates and returns an array of fifty integer values.
    public static int[] findArray()
    {
        
        int[] arr = new int[50];
        Random random = new Random();

        
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(10, 50);
        }

        return arr;
    }

    //two bool variables and returns true if they have the same value, false otherwise
    public static bool checkBool(bool b1, bool b2)
    {
        if (b1 == true && b2 == true)
        {
            return true;
        }
        else if (b1 == false && b2 == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //int and a double and returns their product.
    public static double findMult(int num1, double num2)
    {
        return num1*num2;
    }

    // two-dimensional array of integers and returns the average of the entries.
    public static double find2DAvg(int[,] arr)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i<arr.GetLength(0); i++)
        {
            for (int j = 0; j<arr.GetLength(1); j++)
            {
                sum += arr[i, j];
                count++;
            }
        }

        return sum/count;
    }
    
    public static void Main()
    {
        
        showMeters(753);

        
        showSum(10, 20);

        
        Console.WriteLine(average(75.3, 96.5, 45.8, 69.0, 44.6));

        
        Console.WriteLine(randomSum());

        
        Console.WriteLine(DivisibleBy3(60, 20, 40));

        
        smallString("ball", "Juice wrld");

        
        int[] arr = { 15, 364, 45, 90, 600 };
        Console.WriteLine(findMaxElement(arr));

        
        int[] newArray = findArray();
        foreach (var item in newArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        
        Console.WriteLine(checkBool(false, false));

        
        Console.WriteLine(findMult(10, 20.5));

        
        int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(find2DAvg(arr2D));
    }
}
