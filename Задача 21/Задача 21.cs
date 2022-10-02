void task21()
{
    Console.WriteLine("Введите координаты точки А: ");
    Console.WriteLine("x: "); 
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y: "); 
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("z: "); 
    int az = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B: ");
    Console.WriteLine("x: "); 
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y: "); 
    int by = Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine("z: "); 
    int bz = Convert.ToInt32(Console.ReadLine());  

    int k = bx - ax;
    int m = by - ay;
    int p = bz - az;

    double length = Math.Sqrt(k * k + m * m + p * p);
    length = Math.Round(length, 2);
    Console.WriteLine($" Длина {length}");
}
 task21();