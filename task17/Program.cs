//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите координату точки по x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки по y");
int y = Convert.ToInt32(Console.ReadLine());
if( x > 0 && y > 0)
{
    Console.WriteLine("Точка лежит в плоскости 1");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка лежит в плоскости 2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка лежит в плоскости 3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка лежит в плоскости 4");
}
else
{
    Console.WriteLine("Невозможно определить координатную четверть");
}