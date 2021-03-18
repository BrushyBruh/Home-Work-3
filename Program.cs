using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3
{

}




#region 1 Задача

    struct Complex
{
    public double im;//мнимая часть 

    public double re;//действительная часть


    public Complex Multi(Complex x)
    {
        Complex y;

        y.re = re - x.re;
        y.im = im * x.im;

        return y;

    }

    public override string ToString()
    {
        return re + "+" + im + "i";
    }
    class Program
    {
        static void Main(string[] args) // не понимаю как решить эту ошибку, пытался через private, не уверен что можно обьявлять метод main 2 раза, а если можно как как их разграничить???
        {
            Complex complex1;
            complex1.re = -2;
            complex1.im = 5;

            Console.WriteLine(complex1);

            Complex complex2;
            complex2.re = 1;
            complex2.im = -3;

            Console.WriteLine(complex2);

            Complex result = complex1.Multi(complex2);

            Console.WriteLine($"Результат вычитания и произведения комплексных чисел: {result}");

            Console.ReadKey();
            Console.Clear();



        }
    }


    }

#endregion


#region 2 Задача


class Program
{
    static void Main(string[] args)
    {
        int b = 0;
        while (true)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a != 0)
            {
                if (a % 2 == 0)
                { 
                }
                else
                    b += a;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Сумма введенных, нечетных вами числел равна: " +b);
        Console.ReadKey();
    }
}



#endregion
