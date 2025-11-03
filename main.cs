using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Завдання 1 ===");
        var r = new Random();
        int[,] a = new int[5, 5];
        int[] b = new int[25];
        for (int i = 0, k = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                a[i, j] = r.Next(-100, 101);
                b[k++] = a[i, j];
                Console.Write($"{a[i, j],5}");
            }
            Console.WriteLine();
        }
        int min = b[0], max = b[0], mi = 0, ma = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] < min) { min = b[i]; mi = i; }
            if (b[i] > max) { max = b[i]; ma = i; }
        }
        if (mi > ma) { int t = mi; mi = ma; ma = t; }
        int s = 0;
        for (int i = mi + 1; i < ma; i++) s += b[i];
        Console.WriteLine($"\nМінімум: {min}, Максимум: {max}, Сума між ними: {s}");

        Console.WriteLine("\n=== Завдання 2 ===");
        Console.Write("Введіть вираз: ");
        string x = Console.ReadLine();
        int rSum = 0;
        string n = "";
        char o = '+';
        foreach (char c in x)
        {
            if (char.IsDigit(c)) n += c;
            else if (c == '+' || c == '-')
            {
                int val = int.Parse(n);
                rSum = o == '+' ? rSum + val : rSum - val;
                n = "";
                o = c;
            }
        }
        if (n != "")
        {
            int val = int.Parse(n);
            rSum = o == '+' ? rSum + val : rSum - val;
        }
        Console.WriteLine($"Результат: {rSum}");
    }
}
