//  Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

void CheckNums(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0)
    {
        System.Console.WriteLine(M);
    }
    CheckNums(M + 1, N);
}

int NumFirst = ReadInt("Введите первое число");
int NumLast = ReadInt("Введите второе число");
CheckNums(NumFirst, NumLast);