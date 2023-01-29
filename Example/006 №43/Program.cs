Console.Write("Введите k1: ");
float k1 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите b1: ");
float b1 = Convert.ToSingle(Console.ReadLine());

Console.Write("Введите k2: ");
float k2 = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите b2: ");
float b2 = Convert.ToSingle(Console.ReadLine());


float x = (-b1 + b2)/(k1-k2);
float y = k1*x+b1;

Console.Write($"Точка пересечения прямых [{y},{x}]");