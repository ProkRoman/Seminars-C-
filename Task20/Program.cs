// Напишите программу которая принимает координаты двух 
// точек и находит расстояние между ними в 2Д пространстве

// А (3,6); В(2,1) -> 5,09

Console.WriteLine("Введите координаты точки A ");
Console.Write("X1; ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y1; ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");
Console.Write("X2; ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y2; ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, x2, y1, y2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(int a1, int a2, int b1, int b2)
{
    double dist = Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2));
    return dist;
}