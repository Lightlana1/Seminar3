        int num, rem, sum = 0, temp;
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        while (num > 0)
        {
            rem = num % 10;  
            num = num / 10; 
            sum = sum * 10 + rem; 
  
        }

        if (temp == sum) 
        {
            Console.WriteLine("Число палиндром");
        }
        else
        {
            Console.WriteLine("Число не палиндром");
        }
        Console.ReadLine();