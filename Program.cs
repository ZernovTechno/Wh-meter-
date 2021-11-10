using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ток (Амперы) ");
            double A = float.Parse(Console.ReadLine());
            Console.Write("Введите напряжение (Вольты) ");
            double V = float.Parse(Console.ReadLine());
            Console.Write("Введите время работы устройства (Минуты) ");
            double T = float.Parse(Console.ReadLine());

            double W;
            double h;
            double Wh;
            double S;

            W = V * A;

            h = T * 0.016667;

            Wh = W * h;

            S = Wh * 0.00192;

            Console.Write("Будет потреблено ");
            Console.Write(Wh - Wh % 0.001);
            Console.Write(" ВаттЧасов \n");
            Console.Write("Это будет стоить ");
            Console.Write(S - S % 0.001);
            Console.Write(" рублей \n");

            System.Threading.Thread.Sleep(999999999);

        }
    }
}
