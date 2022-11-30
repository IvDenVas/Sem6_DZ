// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3 

int num = InputFromUser("Задайте размер массива: ");
int[] array = ElArrayFromUser(num, -100, 100);
int count = 0;

for (int i = 0; i < num; i++)
{
    if (array[i] > 0) count++;
}

Console.WriteLine(String.Join(", ", array) + " -> " + count);

static int InputFromUser (string message)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int num))
            if (num > 0) return num;
        Console.WriteLine("Ошибка ввода!");
    }
}

int[] ElArrayFromUser(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return res;
}