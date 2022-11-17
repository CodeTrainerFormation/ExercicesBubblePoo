namespace Demo
{

    delegate int MyFactoDelegate(int number);

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            MyFactoDelegate del = null;
            
            del += (number) =>
            {
                if (number < 2)
                    return 1;
                else
                    return number * del(number - 1);
            };

            int result = del(5);

        }


        static int Facto(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            else
            {
                return number * Facto(number - 1);
            }
        }

        static int FactoTwo(int number)
        {
            if (number < 2)
                return 1;
            else
                return number * Facto(number - 1);
        }
    }
}