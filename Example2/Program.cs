// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] a_coord = { 0, 0, 0 }, b_coord = { 0, 0, 0 };

void Get_coord(double[] dot)
{
    for (int i = 0; i < 3; i++)
    {
        dot[i] = Convert.ToInt32(Console.ReadLine());
    }
}

double Get_distance(double[] first, double[] second)
{
    double result=0;
    for (int i = 0; i < 3; i++)
    {
        result += (second[i]-first[i])*(second[i]-first[i]);
    }
    return Math.Sqrt(result);
}

Console.WriteLine("Введи координаты точки А в 3D пространстве через Enter:");
Get_coord(a_coord);
Console.WriteLine("Введи координаты точки B в 3D пространстве через Enter:");
Get_coord(b_coord);

Console.WriteLine($"Расстояние между точками А и В = {Get_distance(a_coord, b_coord)}");