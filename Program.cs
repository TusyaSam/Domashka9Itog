// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Clear();
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// void NatChisla(int N)
// {
//     if (N > 0) 
//     {
//         System.Console.Write($"{N} ");
//         NatChisla(N-1);                
//     }
// }
// NatChisla(N);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// if (M > N) // opredeliaem bolshee chislo
// {
//     int temp = M;
//     M = N;
//     N = temp;
// }



// int Sum(int M, int N)
// {
//     if (N >= M)
//     {
//         return M + Sum(M + 1, N); // 1,2,3,4,5 - 1 prohod 1+Sum(2,5), 2 prohod 1+2+Sum(3,5)
//     }
//     return 0;
// }

// if (M == N) System.Console.WriteLine($"Числа равны, их сумма = {M + N}");
// if (M != N) System.Console.WriteLine($"Сумма = {Sum(M, N)}");





// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29











// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Clear();
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// void NatChisla(int count, int N)
// {
//     if (N >= count)
//     {
//         System.Console.Write($"{count} ");
//         NatChisla(count+1,N);
//     }
// }
// NatChisla(count,N);




// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.Clear();
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// if (M>N)
// {
//     int temp=M;
//     M=N;
//     N=temp;
// }

// void NatChisla(int M, int N)
// {
//     if (N >= M)
//     {
//         System.Console.Write($"{M} ");
//         NatChisla(M+1,N);
//     }
// }
// NatChisla(M,N);


//Zadacha_factorial

// int Fact(int num)
// {
//     if (num==1) return 1; //tochka vihoda

//     return num*Fact(num-1); // =5*Fact(4), a Fact(4)=4*Fact(3)
// }

// System.Console.WriteLine(Fact(5));

// Pадача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Clear();
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int Sum (int N)
// {
//     if (N==0) return 0;
//     return N%10+Sum(N/10); //15616 = 6+Sum(1561)=6+1+Sum(156)
// }
// System.Console.WriteLine(Sum(N));  


// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Clear();
// Console.Write("Введите A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("В какой степени? B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int Stepen (int A, int B)
// {
//     if (B==0) return 1;
//     return A*Stepen(A,B-1);
// }
//  System.Console.WriteLine(Stepen(A,B)); 