/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{

int i = number % 10; //остаток от деления на 10. 3546--> 6; 354-->4...
number = number / 10; // 3546/10= 354;354/10-->35...
sum = sum + i; // sum=0+6=6; sum=6+4...
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
