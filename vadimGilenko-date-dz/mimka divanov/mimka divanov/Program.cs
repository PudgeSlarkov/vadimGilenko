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
                            if (n>31)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            
                            n++;
                            Console.WriteLine($"next date: {m}.{n}.{g}.");
                            n--;
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
                            
                            if (n > 29)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}.");
                            n--;
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
                            
                            if (n > 30)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}.");
                            n--;
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
                            
                            if (n > 30)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}.");

                            n--;
                            n--;
                            Console.WriteLine($"predidushyaya date: {m}.{n}.{g}");

                            
                        }
                        return;
                    }
                case 5:
                    {
                        if (n > 31)
                        {
                            Console.WriteLine("В мае не может быть больше 31 дня");
                        }
                        else if (n <= 31)
                        {
                            
                            if (n > 31)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;
                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                            
                        }

                        return;
                    }
                case 6:
                    {
                        if (n > 30)
                        {
                            Console.WriteLine("В июне не может быть больше 30 дней");
                        }
                        else if (n <= 30)
                        }
                          n++;
                            

                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;

                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                            if (n > 30)
                            {

                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");

                            }
                        }

                        return;
                    }
                case 7:
                    {
                        if (n > 31)
                        {
                            Console.WriteLine("В июль не может быть больше 31 дня");
                        }
                        else if (n <= 31)
                        {
                            
                            if (n > 31)
                            {
                                Console.WriteLine("НАЙН!");
                               n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;
                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                        }

                        return;
                    }
                case 8:
                    {
                        if (n > 31)
                        {
                            Console.WriteLine("В июле не может быть больше 31 дня");
                        }
                        else if (n <= 31)
                        {
                            
                            if (n > 31)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                           
                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;

                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                        }

                        return;
                    }
                case 9:
                    {
                        if (n > 30)
                        {
                            Console.WriteLine("В сентябре не может быть больше 30 дней");
                        }
                        else if (n <= 30)
                        {
                            
                       
                            if (n > 30)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            
                            n++;
                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;
                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                        }

                        return;
                    }
                case 10:
                    {
                        if (n > 31)
                        {
                            Console.WriteLine("В октябре не может быть больше 31 дня");
                        }
                        else if (n <= 31)
                        {
                           
                            
                            if (n > 31)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;
                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                        }

                        return;
                    }

                case 11:
                    {
                        if (n > 30)
                        {
                            Console.WriteLine("В ноябре не может быть больше 30 дня");
                        }
                        else if (n <= 30)
                        {
                            
                            
                            if (n > 30)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;

                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                        }

                        return;
                    }
                case 12:
                    {
                        if (n > 31)
                        {
                            Console.WriteLine("В декабре не может быть больше 31 дня");
                        }
                        else if (n <= 31)
                        {
                            
                            
                            if (n > 31)
                            {
                                Console.WriteLine("НАЙН!");
                                n = Convert.ToInt32(null);
                                Console.WriteLine($"next date : {m + 1}.{n + 1}.{g}");
                            }
                            n++;
                            
                            Console.WriteLine($"next date: {m}.{n}.{g}");
                            n--;
                            n--;
                            Console.WriteLine($"predidushaya date: {m}.{n}.{g}");
                        }

                        return;
                    }

            }
            Console.ReadKey();
        }
    }
}

























































































































            