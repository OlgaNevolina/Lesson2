Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Третья цифра числа: ");
Console.WriteLine(num > 99 ? num.ToString()[2] : "Третьей цифры нет");
