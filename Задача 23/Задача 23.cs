 void task23()
 {
    Console.WriteLine("Число N");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Число\tКуб");
    for (int i=1; i <= number; i++)
    {
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i,3));
    }

 }
 task23();
