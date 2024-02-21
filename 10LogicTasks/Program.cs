using System;
using System.Security.Cryptography.X509Certificates;

class Program 
{
    public static void Main()
    {
        //Coletando o maior número
        int result = Task1();
        Console.WriteLine("Max Number: " + result);
    }

    public static int Task1()
    {
        List<int> nums = new List<int> { 1, 2, 3 };
        int maxNum = nums[0];

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] > maxNum)
            {
                maxNum = nums[i];
            }
        }
        return maxNum;
    }
}
