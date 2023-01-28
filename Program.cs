void Ex64()
{
    void CountDown(int startNumber)
    {
        //Console.Write(startNumber);
        while (startNumber > 0)
        {
            Console.Write(startNumber + ", ");
            startNumber--;
            CountDown(startNumber);
            break;
        }
       
    }
    Console.WriteLine("Введите число:");
    int enter = int.Parse(Console.ReadLine());
    CountDown(enter);
    Console.WriteLine();
}

// выполнение по нажатию enter:  if (e.KeyCode == Keys.Enter);

//Ex64();

void Ex66(){
    Console.WriteLine("Введите первое число");
    int m = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите второе число");
    int n = int.Parse(Console.ReadLine());

    int Sum(int num1, int num2){
        int counter = 0;
        while(num1<=num2){
            counter += num1;
            num1++;
        }
        return counter;
    }
    
    int sum = Sum(m, n);
    Console.Write("Сумма всех натуральных чисел, лежащих в промежутке между двумя введёнными числами, равняется: ");
    Console.WriteLine(sum);

}

//Ex66();

 void Ex68(){    //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
                 // m = 2, n = 3 -> A(m,n) = 9
                 // m = 3, n = 2 -> A(m,n) = 29

    Console.WriteLine("Введите первое число: ");
    uint m = uint.Parse(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");
    uint n = uint.Parse(Console.ReadLine());

    if (m >= 0 && n >= 0)
    {
        static uint A(uint m, uint n)
        {
            if (m == 0)
                return n + 1;
            else
              if ((m != 0) && (n == 0))   // из-за незнания что такое функция Аккермана и зачем она используется, 
                                          //эта функция не работает, я не знаю почему и из-за чего, и как она вообще должна выводить результат одним числом
                return A(m - 1, 1);
            else
                return A(m - 1, A(m, n - 1));
        }

        uint result = A(m, n);

        Console.WriteLine(result);
    } else
    {
        Console.WriteLine("Введите положительные числа");
    }
}

Ex68();