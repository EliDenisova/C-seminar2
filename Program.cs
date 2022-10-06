// See https://aka.ms/new-console-template for more information


// int rundomNumber = new Random().Next(100, 1000);

// Console.WriteLine(rundomNumber);

// int a = rundomNumber / 100;
// Console.WriteLine(a);
// int b = rundomNumber % 10;
// Console.WriteLine(b);


// Console.WriteLine((a*10) + b);


// Console.WriteLine("Введите первое число");
// int first = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число");
// int second = Convert.ToInt32(Console.ReadLine());

// if (first == 0) 
// {
//    Console.WriteLine("нельзя делить на 0"); 
// }
// else if (second % first == 0)
// {
//     Console.WriteLine(first + " является кратным " + second);
// }
// else Console.WriteLine(first + " не является кратным " + second);


// Console.WriteLine("Введите первое число");
// int first = Convert.ToInt32(Console.ReadLine());

// if (first == 0) 
// {
//    Console.WriteLine("нельзя делить на 0"); 
// }
// else if (first % 7 == 0 && first % 23 == 0)
// {
//     Console.WriteLine(first + " является кратным 7 и 23");
// }
// else Console.WriteLine(first + " не является кратным 7 и 23");

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

if (first == 0 && second == 0) 
{
   Console.WriteLine("нельзя умножать на 0"); 
}
else if (first * first == second || second * second == first)
{
    Console.WriteLine("одно число является квадратом другого");
}
else Console.WriteLine("одно число не является квадратом другого");