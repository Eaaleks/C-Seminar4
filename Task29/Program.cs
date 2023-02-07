/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] array  = new int[8];

void InitArray(int[] array)
{
int length = array.Length; //Переменной передаетя значение равное длине массива
int index = 0; //счетчик элементов
Random rnd = new Random(); //переменную пишем с большой буквы
while (index<length)
{
    array[index] = rnd.Next(); //случайное заполнение первого элемента массива
    index++; //увеличиваем счетчик элементов на 1
}
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
InitArray(array);
PrintArray(array);