//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
bool palindrom (int num)
{
    string number = num.ToString();
    if(number[0] == number[4] && number[1] == number[3]) 
    {
        return true;
    }
 
    else 
    return false;
}
Console.Write("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
bool result = palindrom (num);

Console.WriteLine($"Является ли число {num} палиандром? -> {result}");
*/


//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
//   l^2 = (x2-x1)^2+(y2-y1)^2+(z2-z1)^2

/*
double FindDistance(double xa, double xb, double ya, double yb, double za, double zb)
{
     return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));

}

Console.WriteLine("Input Coordinat xa");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Coordinat xb");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Coordinat ya");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Coordinat yb");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Coordinat za");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Coordinat zb");
double zb = Convert.ToDouble(Console.ReadLine());

double result = FindDistance(xa, xb, ya, yb, za, zb);

Console.WriteLine($"Расстояние между точками в 3D пространстве = {result}");
*/


//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void QubNumbers(int num)
{
    int current = 1;
    while (current<=num)
    {   
        Console.WriteLine($"Куб числа{current} = {current * current * current}");
        current++;
    }
}

Console.WriteLine("Input Number:");
int num = Convert.ToInt32(Console.ReadLine());

QubNumbers(num);


