using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double[] numbers = new double[]
            //{
            //    10.1,
            //    20.2,
            //    30.3,
            //    40.4,
            //    50.5,
            //};
            //Console.WriteLine("Toplam : " + numbers.Sum());

            //double toplam = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    toplam += numbers[i];
            //}
            //Console.WriteLine("Toplam2 : " + toplam);

            // *** Multidimensional Arrays
            ////string[,] bolgelerVeSehirler = new string[3,2];
            ////bolgelerVeSehirler[0, 0] = "Marmara";
            ////bolgelerVeSehirler[0, 1] = "Istanbul";
            ////bolgelerVeSehirler[1, 0] = "Icanadolu";
            ////bolgelerVeSehirler[1, 1] = "Ankara";
            ////bolgelerVeSehirler[2, 0] = "Ege";
            ////bolgelerVeSehirler[2, 1] = "Izmir";

            ////Console.WriteLine(bolgelerVeSehirler[0,1]);


            // ***
            string[,] bolgelerVeSehirler = new string[3, 2] // 3 satirdan ve 2 sutudan olusan array
            {                                               // 3'un index degeri : 0 , 2'nin index degeri ise 1.
              {"Marmara" , "istanbul"},
              {"Icanadolu" , "Ankara"},
              {"Ege", "Izmir"}
            };

            for (int satir = 0; satir < bolgelerVeSehirler.GetUpperBound(0); satir++) // getUpperBound -- > last value
            {
                for (int sutun = 0; sutun < bolgelerVeSehirler.GetUpperBound(1); sutun++)
                {
                    Console.Write(bolgelerVeSehirler[satir,sutun] + " ");
                    
                }
                Console.WriteLine();
                
            }


            Console.Read();
        }
    }
}
