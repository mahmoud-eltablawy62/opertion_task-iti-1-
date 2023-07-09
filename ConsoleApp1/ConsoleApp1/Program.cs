
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num1");
            float num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the num1");
            float num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"num + num2 = {num + num2}");
            Console.WriteLine($"num * num2 = {num * num2}");
            Console.WriteLine($"num / num2 = {num / num2}");
            Console.WriteLine($"num - num2 = {num - num2}");
            Console.WriteLine(-1 + 4 * 6);
        }
    }
}

