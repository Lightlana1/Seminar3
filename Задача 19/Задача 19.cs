    void task19() 
    {   
        int num, rem, sum = 0, temp;
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        temp = num;
        if (num > 9999 && num < 100000)
        {
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

        } 
        else
        {
            Console.WriteLine("Вы ввели неверное число");
        }
    }
    task19(); 