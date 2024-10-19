namespace GenericCSharp_Action_Eps13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> action = (x, y) =>
            {
                Console.WriteLine(x + y);
            };

            action(1, 2);

            Func<int, int, string> func = (x, y) =>
            {
                return (x+y).ToString();
            };

            Console.WriteLine(func(10,12));

            Predicate<int> isOdd = x => 
            {
                return x % 2 == 1; 
            };

            Console.WriteLine(isOdd(1));

            // example of using Predicate
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var resultOdd = list.FindAll(isOdd);

            for(int i = 0; i < resultOdd.Count; i++)
            {
                Console.WriteLine(resultOdd[i]);
            }
        }
    }
}