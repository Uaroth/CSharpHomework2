//Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет
Console.WriteLine("Здравствуйте! Введите целое число");
int wholeNumber = Convert.ToInt32(Console.ReadLine());
if (wholeNumber / 100 >= 1)
{   while (wholeNumber / 100 > 9)
        {
        wholeNumber = wholeNumber / 10;
        }
    int thirdNumber = wholeNumber % 10;
    Console.WriteLine($"Третья цифра числа = {thirdNumber} ");
}
else Console.WriteLine("У числа нет третьей цифры");