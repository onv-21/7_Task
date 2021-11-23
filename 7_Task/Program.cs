// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите длины сторон первого треугольника");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длины сторон второго треугольника");
int d = Convert.ToInt32(Console.ReadLine());
int e = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());
double p1, S1,p2,S2;
getParams(a, b, c,d,e,f, out p1, out S1, out p2, out S2);
if (S1>S2)
{
    Console.WriteLine("Площадь первого треугольника больше и равна {0}",S1);
}
else
{
    Console.WriteLine("Площадь второго треугольника больше и равна {0}",S2);
}

static void getParams(int a, int b, int c, int d, int e, int f,out double p1, out double S1, out double p2, out double S2)
{
    p1 = (a + b + c) / 2;
    p2 = (d + e + f) / 2;
    S1 = Math.Sqrt(p1 * (p1 - a) * (p1 - b) * (p1 - c));
    S2= Math.Sqrt(p2 * (p2 - d) * (p2 - e) * (p2 - f));
}
