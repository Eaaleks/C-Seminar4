/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberOne = numberRequest("Введите первое число:");
int numberTwo = numberRequest("Введите второе чило: ");

int Result = (int) Math.Pow(numberOne, numberTwo);

Console.Write($"{Result}");

