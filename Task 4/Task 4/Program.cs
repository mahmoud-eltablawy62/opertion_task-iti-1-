
using System;
using System.Transactions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool daysTrue;
            int year = Int32.Parse (Console.ReadLine());
            int month = Int32.Parse(Console.ReadLine());
            
             int Y= Age(year);
            int M = months(month);

           
            int days;
            do
            {
                Console.WriteLine("enter the number of days :- ");
                days = Int32.Parse(Console.ReadLine());
                if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && days <= 31)
                {
                    break;
                }
                else if ((month == 4 || month == 6 || month == 9 || month == 11) && days <= 30)
                {
                    break;
                }
                else if (month == 2 && (days <= 28 || days <= 29))
                {
                    break;
                }
            } while (true);
            if (year >= 2023 && month >= 7 && days >= 10)
            {
                Console.WriteLine("enter anthor data ");
            }
            else
            {
                int d = Days(days);
                int dt = 0;
                if (d == 0)
                {
                    daysTrue = false;

                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        dt = (31 - days) + 10;
                    }
                    else if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        dt = (30 - days) + 10;
                    }
                    else if (month == 2)
                    {
                        if (days == 28)
                        {
                            dt = (28 - days) + 10;
                        }
                        else
                        {
                            dt = (29 - days) + 10;
                        }

                    }
                }
                else
                {
                    daysTrue = true;
                    dt = d;
                }
                int M_;
                int mt = 0;
                if (M == 0)
                {
                    M_ = month - 7;
                    if (M_ == 0)
                    {
                        mt = 0;
                    }
                    else
                    {
                        mt = 12 - M_;
                    }
                    if (Y == 0) { Y = 0; }
                    else
                    {
                        Y = Y - 1;
                    }


                }
                else
                {
                    mt = M;
                }
                Console.WriteLine($"years==>{Y} months===>{mt} days==>{dt} ");

            }

        }
        static int Age(int years )
        {
            if (years > 0 && years < 2023)
            {
                int age = 2023 - years;
                return age;
            }else
            {
                return 0;
            }
        }

        static int months(int months)
        {
           if(months > 0 && months < 7)
            {
                int month = 7 - months;
                return month;
            }else
            {
                return 0;
            }
        }

        static int Days(int DAY)
        {
            if (DAY > 0 && DAY < 10)
            {
                int D = 10 - DAY;
                return D;
            }
            else
            {
                return 0;
            }
        }


    }
}
