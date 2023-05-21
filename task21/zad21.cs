// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A:");
    double ax = double.Parse(Console.ReadLine());
    double ay = double.Parse(Console.ReadLine());
    double az = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
    double bx = double.Parse(Console.ReadLine());
    double by = double.Parse(Console.ReadLine());
    double bz = double.Parse(Console.ReadLine());

    double distance = CalculateDistance(ax, ay, az, bx, by, bz);

    Console.WriteLine("Расстояние между точкой A и точкой B: " + distance.ToString("F2"));

    Console.ReadLine();

    static double CalculateDistance(double ax, double ay, double az, double bx, double by, double bz)
    {
    double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    return distance;
    }