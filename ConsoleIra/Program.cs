namespace ConsoleIra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nala = 23;
            int nala2 = 34;
            string nala3 = "ira1";
            int result1 = Sum(nala3,nala, nala2);
            Console.WriteLine(result1);

            int result2 = Sum("sum2result", 32, 54);
            Console.WriteLine(result2);
            
        }

        private static int Sum(string ira,int x, int y)
        {
            int din = x+y;
            int don = 3;
            don = din;
            Console.WriteLine(don);
            Console.WriteLine(ira);
            return din;
        }


    }
}