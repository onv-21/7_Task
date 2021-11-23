// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Введите длину ребра куба");
int a = Convert.ToInt32(Console.ReadLine());
double S, V;
getParams(a,out S, out V);
Console.WriteLine("Площадь поверхности куба равна {0}, объём куба равен {1}", S, V);
static void getParams(int a,  out double S, out double V)
{
    S = 6 * a * a;
    V = a * a * a;
}