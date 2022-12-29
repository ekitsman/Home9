// Д.з. 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void Natnumbers (int num)
// {  
//     if (num < 0) 
//     Console.Write(" Not a natural number ");
//     if (num > 0)
//     {
//      Console.Write (num +" ");
//      Natnumbers(num-1);
//     }

// }
// Console.Write("Enter a natural number:");
// int numN=Convert.ToInt32(Console.ReadLine());

// Natnumbers(numN);

// 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// static int SumNumbers(int numM, int numN)
// {   if (numM == 0) return (numN * (numN + 1)) / 2;  
//     if (numN == 0) return (numM * (numM + 1)) / 2;  
//     if (numM == numN) return numM;                       
//     if (numM < numN) return numN + SumNumbers(numM, numN - 1); 
//     else return numN + SumNumbers(numM, numN + 1);            
// }

// Console.Write("Enter a number M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a number N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Result = {SumNumbers(M, N )}");
 

// 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
 int FunAkkermana (int naumM, int naumN)
 {
    if (naumM == 0) return naumN + 1;
    else if (naumN == 0) return FunAkkermana(naumM - 1, 1);
    else return FunAkkermana(naumM - 1, FunAkkermana(naumM, naumN - 1));
 }
Console.Write("Enter a number M, non-negative: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number N, non-negative: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result = {FunAkkermana(M, N )}");