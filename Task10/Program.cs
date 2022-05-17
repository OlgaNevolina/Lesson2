Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Вторая цифра числа: ");
Console.WriteLine((num % 100 - num % 10) / 10);
