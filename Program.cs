﻿//\\Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Clear();
// Console.WriteLine("Введите 2 числа, чтобы узнать какое больше. Ведите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 >= num2) 
//     Console.WriteLine("Это число больше: " +num1);
// else 
//     Console.WriteLine("Это число больше: " +num2);

//\\Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Clear();
// int big = 0;
// Console.WriteLine("Введите 3 числа, чтобы узнать какое больше  Ведите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if ((num1 >= num2) && (num1 >= num3))
// big = num1;
// else if ((num2 >= num1) && (num2 >= num3))
//      big = num2;
//      else if ((num3 >= num1) && (num3 >= num2))
//      big = num3;
//     Console.WriteLine("Это число больше: " +big);


//\\ Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


// Console.Clear();
// Console.WriteLine("Введите число чтобы узнать его четность: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%2==0)
//     Console.WriteLine("Это число четное: ");  
// else
//     Console.WriteLine("Это число нечетное: ");   


//\\ Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


Console.Clear();
Console.WriteLine("Введите число (N), а на выходе покажет все чётные числа от 1 до N: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int x = 2; x <= num; x=x+1) 
if (x%2==0)       
   Console.WriteLine(x);