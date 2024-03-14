// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29

int AckermanFunc(int n, int m)
{
   if ( n == 0)
     { return m + 1;}
   if ( m == 0)
     { return AckermanFunc(n - 1, 1); }
   else
     { return AckermanFunc(n - 1, AckermanFunc(n, m - 1)); } 
}

Console.WriteLine("Введите натуральное число M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write($"M = {M}; N = {N} -> A(m,n) = {AckermanFunc(N, M)}");

Console.WriteLine();
