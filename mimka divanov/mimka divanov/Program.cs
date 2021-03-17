using System;

namespace mimka_divanov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите месяц:1.Январь 2.Февраль 3.Март 4.Апрель 5.Май 6.Июнь 7.Июль 8.Август 9.Сентябрь 10.Октябрь 11.Ноябрь 12.Декабрь");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {

                case 1:
                    {
                        if (n > 31)
                        {
                            Console.WriteLine("В январе не может быть больше 31 дня");
                            return;
                        }
                        else if (n <= 31)
                        {
                            n++;
                            Console.WriteLine($"next date: {m}.{n}.{g}.");
                            n--;
                            Console.WriteLine($"predidushyaya date: {m}.{n}.{g}");
                        }
                        return;
                    }
                case 2:
                    {
                        if (n > 29)
                        {
                            Console.WriteLine("В феврале не может быть больше 29 дней");
                            return;
                        }
                        else if (g % 4 == 0 && n <= 29)
                        {
                            n++;
                            Console.WriteLine($"next date: {m}.{n}.{g}.");
                            n--;
                            Console.WriteLine($"predidushyaya date: {m}.{n}.{g}");
                        }
                        return;
                    }
                case 3:
                    {
                        if (n > 30)
                        {
                            Console.WriteLine("В марте не может быть больше 30 дней");
                            return;
                        }
                        else if (n <= 30)
                        {
                            n++;
                            Console.WriteLine($"next date: {m}.{n}.{g}.");
                            n--;
                            Console.WriteLine($"predidushyaya date: {m}.{n}.{g}");
                        }
                        return;
                    }
                case 4:
                    {
                        if (n > 30)
                        {
                            Console.WriteLine("В апреле не может быть больше 30 дня");
                            return;
                        }
                        else if (n <= 30)
                        {
                            n++;
                            Console.WriteLine($"next date: {m}.{n}.{g}.");
                            n--;
                            Console.WriteLine($"predidushyaya date: {m}.{n}.{g}");
                        }
                        return;
                    }
                case 5:
                    { 
                        if (n>31)
                        { 
                            Console.WriteLine (


























































































































                    }


        }
    }
}
