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

void Ex68(){
    
}