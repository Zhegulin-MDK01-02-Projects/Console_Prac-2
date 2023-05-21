// Задание 1
Console.WriteLine("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите n: ");
double n = Convert.ToDouble(Console.ReadLine());
double Y, z, m;
m = (a * a + b) / (b * b - a);
if (m > n)
{
    z = m;
}
else if (n < m)
{
    z = n;
}
else
{
    z = n * Math.Cos(n);
}

Y = (z * z + b - Math.Cos(b)) / Math.Sqrt(b * b + a);
Console.WriteLine(Convert.ToString(Y));

//Задание 2
Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите R: ");
double R = Convert.ToDouble(Console.ReadLine());
if (Math.Sqrt(x * x + y * y) < R)
{
    Console.WriteLine("Точка принадлежит кругу");
}
else
{
    Console.WriteLine("Точка не принадлежит кругу");
}