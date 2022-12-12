// 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* 
Console.WriteLine("Input a number A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num;

if (num > num2)
{
    max = num;
}
else
{
    max = num2;
}


Console.WriteLine(max);
*/


// 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Input a number A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number C: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);
*/

// 3.Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) 
{
    Console.Write ("Yes!");
}
else
{
    Console.Write ("No!");
}
*/


// 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
int num = new Random().Next(1,1000);
int current = 1;

while (current <= num)
{
    if (current % 2 == 0)
    {
        Console.Write(current + " ");
        
    }
current ++;
}
*/
