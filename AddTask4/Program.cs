/*Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
N = 72334 -> 20:5:34 
*/

Console.WriteLine("Введите кол-во секунд");
int number = Convert.ToInt32(Console.ReadLine());
int minutes = number / 60;
int hour = minutes / 60;
Console.WriteLine($"{hour}:{minutes}:{number}");