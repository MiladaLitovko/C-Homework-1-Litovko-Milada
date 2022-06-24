/*Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
N = 4 -> 1, 1, 1, 1
N = 2 -> 1, 1
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count=1;

while(count <= number)
    {
        Console.Write(1 + " ");
        count++;
    }
