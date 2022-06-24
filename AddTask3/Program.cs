//Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.

Console.WriteLine("Введите рост 1-го спортсмена");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост 2-го спортсмена");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите рост 3-го спортсмена");
int numberC = Convert.ToInt32(Console.ReadLine());


if(numberA > numberB && numberB > numberC)
{
    Console.WriteLine($"{numberA}, {numberB}, {numberC}");
}
else if(numberB > numberA && numberA > numberC)
{
    Console.WriteLine($"{numberB}, {numberA}, {numberC}");
}
else if(numberC > numberA && numberA > numberB)
{
    Console.WriteLine($"{numberC}, {numberA}, {numberB}");
}
else if(numberC > numberA && numberB > numberA && numberC > numberB)
{
    Console.WriteLine($"{numberC}, {numberB}, {numberA}");
}
else if(numberB > numberA && numberC > numberA && numberB > numberC)
{
    Console.WriteLine($"{numberB}, {numberC}, {numberA}");
}
else if(numberA > numberB && numberC > numberB && numberA > numberC)
{
    Console.WriteLine($"{numberA}, {numberC}, {numberB}");
}