// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным
Console.WriteLine("Здравствуйте! Введите номер дня недели");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay > 0 && numDay < 8)
{
    if (numDay > 5 && numDay < 8)
    {
        Console.WriteLine("Это выходной день");
    }
    else Console.WriteLine("Это не выходной день");
}
else Console.WriteLine("Нет такого дня в неделе");
