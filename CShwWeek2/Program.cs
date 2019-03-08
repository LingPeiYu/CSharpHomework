using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShwWeek2
{
    class Question6
    {
        public static void Answer()
        {
            Console.WriteLine("6、输入一个数：");
            string input = Console.ReadLine();
            int n;
            bool isPrime;
            if(int.TryParse(input,out n))
            {
                Console.WriteLine("这个数素数因子有：");
                for (int i=1;i<=n/2;i++)
                {
                    if(n%i==0)
                    {
                        isPrime = true;
                        if (i > 2)
                        {
                            for (int j = 2; j < i / 2; j++)
                            {
                                if (i % j == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                        }
                        if(isPrime)
                        {
                            Console.Write("{0} ", i);
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }

    class Question7
    {
        public static void Answer()
        {
            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("7、整数数组为：");
            foreach (int n in test)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            Console.Write("最大值为:");
            int result;
            result = test[0];
            foreach (int n in test)
            {
                if (n > result)
                    result = n;
            }
            Console.WriteLine($"{result}");
            Console.Write("最小值为:");
            result = test[0];
            foreach (int n in test)
            {
                if (n < result)
                    result = n;
            }
            Console.WriteLine($"{result}");
            Console.Write("平均值为:");
            result = 0;
            foreach (int n in test)
            {
                result += n;
            }
            Console.WriteLine("{0}", (double)result / test.Length);
            Console.Write("和为:");
            result = 0;
            foreach (int n in test)
            {
                result += n;
            }
            Console.WriteLine($"{result}");
        }
    }

    class Question9
    {
        public static void Answer()
        {
            List<int> primes = new List<int>();
            for(int i=2; i<=100;i++)
            {
                primes.Add(i);
            }
            for(int i=2;i<=100;i++)
            {
                foreach(int j in primes.ToArray())
                {
                    if (j > i && j % i == 0)
                        primes.Remove(j);
                }
            }
            Console.WriteLine("2~100之间的素数有：");
            foreach (int n in primes)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Question6.Answer();
            Question7.Answer();
            Question9.Answer();
        }
    }
}
