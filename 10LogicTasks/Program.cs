using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

class Program 
{
    public static void Main()
    {
        //Task1();
        //Task2();
        //Task3();
        Task4();
    }

    public static void Task1()
    {
        Console.WriteLine("Exercicio 1 - Respeitando a seguinte lista { 1, 2, 3 } colete o maior valor:");
        List<int> nums = new List<int> { 1, 2, 3 };
        int maxNum = nums[0];

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] > maxNum)
            {
                maxNum = nums[i];
            }
        }
        Console.WriteLine("Maior valor: " + maxNum);
    }

    public static void Task2()
    {
        Console.WriteLine("Exercicio 2 - Construa um algoritmo que leia uma idade e a expresse em Meses, dias e horas.");
        Console.WriteLine("Idade: ");

        int Age = Int16.Parse(Console.ReadLine());
        int Mounths = Age * 12;
        int Days = 30 * Mounths;
        int Hours = 24 * Days;

        Console.WriteLine($"A Idade: {Age} tem: \n {Mounths} meses \n {Days} dias \n {Hours} horas \n");
    }

    public static void Task3()
    {
        Console.WriteLine("Exercicio 3 - Calculo de fatorial \n Deseja calcular o valor de qual fatorial:");
        int baseFat = Int32.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= baseFat; i++)
        {
            result *= i;
            Console.WriteLine(i);
        }

        Console.WriteLine($"O fatorial de {baseFat} é {result}");
    }

    public static void Task4()
    {
        Console.WriteLine("Exercicio 4 - Calcular Fibonacci. \nQual número deseja calcular: ");
        int baseFib = Int32.Parse(Console.ReadLine());

        int resultado = CalcularFibonacci(baseFib);
        Console.WriteLine($"O Fibonacci de {baseFib} é {resultado}.");

        static int CalcularFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                int fibAnterior = 0;
                int fibAtual = 1;

                for (int i = 2; i <= n; i++)
                {
                    int temp = fibAtual;
                    fibAtual = fibAnterior + fibAtual;
                    fibAnterior = temp;
                }

                return fibAtual;
            }
        }
    }

}
