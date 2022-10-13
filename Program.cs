//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("This program will raise the first number to a power of second number.\nIf you want to try with random numbers print \"random\" or press enter to input them by urselve");
string UserChoice = Console.ReadLine()!;
if (UserChoice.ToLower() == "random")
{
    int FirstNumber = new Random().Next(10);
    int SecondNumber = new Random().Next(10);
    Console.WriteLine($"The result of a number {FirstNumber} raised to a power {SecondNumber} is: {FirstNumberExpSecondNubmer(FirstNumber, SecondNumber)}");

}
else
{
    Console.WriteLine("Enter first number");
    int FirstNumber = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter second number");
    int SecondNumber = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"The result of a number {FirstNumber} raised to a power {SecondNumber} is: {FirstNumberExpSecondNubmer(FirstNumber, SecondNumber)}");

}

int FirstNumberExpSecondNubmer (int A, int B)
{
    int Exp = 1;
    for (int i = 1; i <= B; i++)
    {
        Exp = Exp * A;
    }
    return Exp;
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Task27Number = new Random().Next(100);
Console.WriteLine();
Console.WriteLine($"The Sum of digits in the number {Task27Number} is: {SumDigitsInNumber(Task27Number)}");

int SumDigitsInNumber (int X)
{
    int length = Convert.ToString(X).Length;
    int result = 0;
    for (int i = 1; i <= length; i++)
    {
        result = result + X % 10;
        X = X / 10;
    }
    return result;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = GetArray(8);
Console.WriteLine();
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}