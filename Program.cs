using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////Задача 2
            int a,b;
            string convert;

            Console.Write("Введите значение переменной a:");
            convert = Console.ReadLine();
            a = Convert.ToInt32(convert);

            Console.Write("Введите значение переменной b:");
            convert = Console.ReadLine();
            b = Convert.ToInt32(convert);

            if(a == b){
                a=b=0;
            }else{
                if(a>b)b=a;
                if(b>a)a=b;
            }
            Console.WriteLine($"Новое значение а: {a} и b: {b}");
            
            //////////////////////////////////////////////////////
            ///////Задача 3
            int operand1 = 55,operand2 = 0;
            Console.Write("Введите ариф. операцию: ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    Console.WriteLine("Резултат: {0}",operand1+operand2);
                    break;
                case "-":
                    Console.WriteLine("Резултат: ", operand1-operand2);
                    break;
                case "*":
                    Console.WriteLine("Резултат: {0}", operand1*operand2);
                    break;
                case "/":
                    if(operand1==0||operand2==0){
                    Console.WriteLine("Ошибка деление на ноль!");
                    break;
                    }else{
                         Console.WriteLine("Резултат: {0}", operand1/operand2);
                    break;
                    }

                default:
                break;
                
            }
            ////////////////////////////////////////////////
            /////////Задача 4
            int x;
            string convert1;

            Console.Write("Введите значение: ");
            convert1 = Console.ReadLine();
            x = Convert.ToInt32(convert1);
           
           if(x<=14)Console.WriteLine("Число в диапазоне 0-14");
           else if(x>14&&x<=35)Console.WriteLine("Число в диапазоне 14-35");
           else if(x>35&&x<=50)Console.WriteLine("Число в диапазоне 35-50");
           else if(x>50&&x<=100)Console.WriteLine("Число в диапазоне 50-100");
           else Console.WriteLine("Число не входит ни в один из имеющихся числовых промежуток!");

           Console.ReadKey();
        }
    }
}