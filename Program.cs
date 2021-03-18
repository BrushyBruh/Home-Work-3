using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_3
{
    struct Complex
    #region 1 вариант
    {
        public double im;//мнимая часть 

        public double re;//действительная часть

        
        public Complex Multi(Complex x)
        {
            Complex y;

            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;

            return y;

        }

        public override string ToString()
        {
            return re + "+" + im + "i";
        }


        
        class Program
        {
            static void Main(string[] args)
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

                Console.WriteLine($"Результат вычитания комплексных чисел: {result}");

                Console.ReadKey();




            }
        }
        
            
        }
    }
#endregion

