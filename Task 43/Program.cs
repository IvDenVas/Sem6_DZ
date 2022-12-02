// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double num1 = userInput("Введите b1: ");
double num2 = userInput("Введите k1: ");
double num3 = userInput("Введите b2: ");
double num4 = userInput("Введите k2: ");

double resX = ResultX(num1, num2, num3, num4);
double resY = ResultY(num1, num2, num3, num4);

Console.Write($"b1 = {num1}, k1 = {num2}, b2 = {num3}, k2 = {num4} -> ({resX}, {resY})");

static int userInput (string message)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
            return num;
        Console.WriteLine("Ошибка ввода!");
    }
}

double ResultX (double a, double b, double c, double d)
{
    double x = (c - a) / (b - d);
    return x;
}

double ResultY (double a, double b, double c, double d)
{
    double y = b * (c - a) / (b - d) + a;
    return y;
}