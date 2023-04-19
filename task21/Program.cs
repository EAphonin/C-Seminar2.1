// Принимает на вход координаты 2х точек и находит расстояние между ними в 3D пространстве
int x1 = GetUserInput("Введите координату х для точки А:");
int y1 = GetUserInput("Введите координату y для точки А:");
int z1 = GetUserInput("Введите координату z для точки А:");
int x2 = GetUserInput("Введите координату х для точки B:");
int y2 = GetUserInput("Введите координату y для точки B:");
int z2 = GetUserInput("Введите координату z для точки B:");

double tempX = Math.Pow(x2 - x1, 2);
double tempY = Math.Pow(y2 - y1, 2);
double tempZ = Math.Pow(z2 - z1, 2);
double result = Math.Sqrt(tempX + tempY + tempZ);

Console.WriteLine($"A({x1},{y1},{z1}) , B({x2},{y2},{z2}) -> {result:f2}");

static int GetUserInput(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        int UserInput;
        if (int.TryParse(Console.ReadLine(), out UserInput))
            return UserInput;
        else Console.WriteLine("Ошибка ввода");

    }
}