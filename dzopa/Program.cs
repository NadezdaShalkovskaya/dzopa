
////Передача параметров по ссылке
//void SwapRef(ref int x, ref int y)
//{
//    int temp = x;
//    x = y;
//    y = temp;
//}
//int a = 6, b = 8;
//Console.WriteLine($"a={a} b ={b}");
//SwapRef(ref a, ref b);
//Console.WriteLine($"a = {a} b={b}");
////Выходные параметры. модификатор аут
//void SumOut(int a, int b, out int res)
//{
//    res = a + b;
//}
//int res;
//SumOut(a, b, out res);
//Console.WriteLine("res=" + res);
//SumOut(a, b, out int result);
//Console.WriteLine("result=" + result);
////Входные параметры.in 
//int Square(in int n)
//{
//    //n = 8
//    return n * n;
//}
//Console.WriteLine("5^2=" + Square(5));
////Массив параметов и ключевое слово params
//int SumParams(params int[] numbers)
//{
//    int sum = 0;
//    foreach (int item in numbers)
//    {
//        sum += item;
//    }
//    return sum;
//}
//Console.WriteLine(SumParams(5, 7, 3, 7, 4, 8));
////Массив в качестве параметра
//int SumMas(int[] mas)
//{
//    int sum = 0;
//    foreach (int item in mas)
//    {
//        sum += item;
//    }
//    return sum;
//}
//int[] massive = new int[10];
//for (int i = 0; i < massive.Length; i++)
//{
//    massive[i] = new Random().Next(10, 100);
//    Console.WriteLine(massive[i] + "");
//}
//Console.WriteLine("Sum=" + SumMas(massive));
////Рекурсивные функции
////Рекурсия- представляет такую конструкцию при которой функция вызывает саму себя (прямая)
//// Не рекурсивная функция факториала
//long Factorial(int n)
//{
//    long F = 1;
//    for (int i = 1; i < n; i++) F *= i;
//    return F;
//}
//// Рекурсивная функция факториала
//long FactorialRecursive(int n)
//{
//    if (n == 1 | n == 0) return 1;
//    else return n * FactorialRecursive(n - 1);
//}
//int F1(int n)
//{
//    if (n < +0) return 0;
//    else if (n > 0 && n % 2 == 0) return F1(n / 2);
//    else return 1 + F1(n - 1);
//}
//Console.WriteLine(Factorial(5));
//Console.WriteLine(FactorialRecursive(5));
//int count = 0;
//for (int i = 1; i < 1000; i++)
//{
//    if (F1(i) == 3) count++;
//}
//Console.WriteLine(count);
//int Fib(int n)
//{
//    if (n == 1) return 0;
//    else if (n == 2 || n == 3) return 1;
//    else return Fib(n - 2) + Fib(n - 1);
//}
//for (int i = 1; i <= 30; i++)
//{
//    Console.Write(Fib(i) + "");
//}
//Console.WriteLine();
Console.WriteLine("Счастливые шестизначные номера");
for (int number = 100000; number <= 999999; number++)
{
    int firstHalf = number / 1000;
    int secondHalf = number % 1000;
    int firstSum = SumOfDigits(firstHalf);
    int secondSum = SumOfDigits(secondHalf);
    if (firstSum == secondSum)
    {
        Console.WriteLine(number);
    }
}
static int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;   
    }
    return sum;
}