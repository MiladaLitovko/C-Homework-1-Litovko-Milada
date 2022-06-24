//Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int zero = 0;
int count = numberA; 


while(count <= numberB)
{
    count = count + numberA;
    zero = zero + 1;
}
Console.Write(zero);