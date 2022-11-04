//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа
Console.WriteLine("Здравствуйте! Введите целое трёхзначное число");
int wholeNumber = Convert.ToInt32(Console.ReadLine());
int firstNumbers = wholeNumber / 10;
int secondNumber = firstNumbers % 10;
Console.WriteLine($"Вторая цифра числа = {secondNumber} ");