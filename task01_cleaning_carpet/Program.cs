namespace task01_cleaning_carpet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num of small carpe: ");
            double small = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the num of large carpe: ");
            double large = Convert.ToDouble(Console.ReadLine());
            double taxi = 0.06;
            double cost = 25 * small + 35 * large;
            double tax = taxi * cost;
            double total = cost + tax;
            Console.WriteLine($"{total}");
            Console.WriteLine("this estimate is valid for 30 days");
        }
    }
}
