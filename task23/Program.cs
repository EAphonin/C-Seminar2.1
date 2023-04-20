int N = GetUserInput("Введите число N:");

Console.Write($"{N} -> ");
for (int i=1; i<=N; i++)
{
    double result = Math.Pow(i,3);
    Console.Write($"{result} ");
}
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