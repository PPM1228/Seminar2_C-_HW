/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/*
int SecondNumber()
{
    Console.WriteLine("Enter your 3-digit number: ");
    int user_number = Convert.ToInt32(Console.ReadLine());
    if (user_number < 100 && user_number > 1001)
    {
        Console.WriteLine("You have entered not a 3-digit number. Read the task again.");
    }
    int future_secondNumber = user_number % 100 / 10;
    return future_secondNumber;
}
Console.WriteLine($"Your new number is {SecondNumber()}");

*/


/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/


/*

int ThirdNumber()
{
    Console.WriteLine("Enter your number: ");
    int user_number = Convert.ToInt32(Console.ReadLine());
    if (user_number < 100)
{
    Console.WriteLine("There is no the third digit in the number entered.");
}
        while (user_number > 999)
    {
        user_number = user_number / 10;     
    }

    int future_thirdNumber = user_number % 10;
    return future_thirdNumber;
}

Console.WriteLine($"Your new number is {ThirdNumber()}");


*/

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */



Console.WriteLine("To know whether it's weekend or not, enter the day number starting from 1 to 7: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());

int WeekDay(int day)
{
    if (day < 1 || day > 7)
    {
        Console.WriteLine("There is only 7 days in a week. Enter the real day number you need.");
    }
    else if (day > 5)
    {
        Console.WriteLine($"{day} is a weekend. Just chill");
    }
    else
    {
       Console.WriteLine($"{day} is a workday, unfortunatelly. Sorry for you, bro");
    }
    return day;
}
Console.WriteLine(WeekDay(numberOfDay));