int number = GetUserInput("Введите пятизначное число:");

int first = number / 10000 % 10;
int second = number / 1000 % 10;
int fourth = number / 10 % 10;
int fifth = number % 10;

if (number > 9999 && number < 100000)
{
    if (first == fifth && second == fourth)
        Console.WriteLine($"{number} - > Полиндром");
    else
        Console.WriteLine($"{number} - > Не полиндром");
}
else
    Console.WriteLine("Должно быть пять цифр !");
static int GetUserInput(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        int UserInput;
        if (int.TryParse(Console.ReadLine(), out UserInput))
            return UserInput;
        else Console.WriteLine("Нужно ввести число !");

    }
}