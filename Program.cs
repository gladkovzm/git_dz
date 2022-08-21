// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Clear();
// Console.WriteLine("Введите 2 числа, чтобы узнать какое больше. Ведите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 >= num2) 
//     Console.WriteLine("Это число больше: " +num1);
// else 
//     Console.WriteLine("Это число больше: " +num2);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
int big = 0;
Console.WriteLine("Введите 3 числа, чтобы узнать какое больше  Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if ((num1 >= num2) && (num1 >= num3))
big = num1;
else if ((num2 >= num1) && (num2 >= num3))
     big = num2;
     else if ((num3 >= num1) && (num3 >= num2))
     big = num3;
    Console.WriteLine("Это число больше: " +big);


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8