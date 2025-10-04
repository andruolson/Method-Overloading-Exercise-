namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 5));
            Console.WriteLine(Add(2.5m, 3.1m));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(8, 8, true));
            Console.WriteLine(Add(8, 8, false));
        }

        //OVERLOAD ONE - Add two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //OVERLOAD TWO - Add two decimals
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        
        //OVERLOAD THREE - Takes two integers and a bool, returns a string
        public static string Add(int a, int b, bool isDollar)
        {
            int sum = a + b;

            if (isDollar)
            {
                if (sum == 1)
                {
                    return $"{sum} dollar";
                }
                else
                {
                    return $"{sum} dollars";
                }
            }
            else
            {
                return sum.ToString();
            }
        }
        }
    }

