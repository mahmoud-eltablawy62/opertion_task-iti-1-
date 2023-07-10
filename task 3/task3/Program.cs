namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
             
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1}is the bigest number");
            }else if(num2> num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} is the bigest number");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"{num3} is the bigest number");
            }
            else { Console.WriteLine("all numbers is equal"); }
        }
    }
}
