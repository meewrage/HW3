//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,10
//A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите координаты точки А по оси х");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по оси y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки В по оси х");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки В по оси y");
double yB = Convert.ToDouble(Console.ReadLine());
double c = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
Console.WriteLine(c);