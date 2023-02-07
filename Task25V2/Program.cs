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
int GetDegree = numberOne;

for (int i = 1; i < numberTwo; i++)
{
    GetDegree= GetDegree*numberOne; //number1 умножается сама на себя i раз
}
Console.WriteLine($"{GetDegree}");