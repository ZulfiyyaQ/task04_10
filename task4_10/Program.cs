namespace task4_10
{
    internal class Program
    {
        static void Main(string[] args)
        { //task1
            //int[] numbers = { 1, 5, 11, -3, 2, 10 };
            //Console.WriteLine(Min(numbers));
            //---------------------------------------------
            //task2
            //Area(7);
            //Area(5,10);
            //Area(2,7,4);
            //Area(3,5,8,4);
        }
        


        public static void Area(int r) 
        {
            Console.WriteLine(3 * (r * r));
        }
        public static void Area(int a,int b) 
        {
            Console.WriteLine(a * b);
        }
        public static void Area(int a,int b,int c)
        {
            Console.WriteLine(a * b + a * c + b * c);
        }
        public static void Area(int a, int b, int c ,int r)
        {
            Console.WriteLine((a + b + c) / 2 * r);
        }












        public static int Min(int[] arr)
        {
            int min = arr[0];


            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            return min;
        }
    }
}



