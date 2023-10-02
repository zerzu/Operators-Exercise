namespace OperatorExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a  == 17 && b == 4) 

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the Radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}");
            Console.WriteLine();    
            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();
        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * radius * radius;

            return area;
        }
    }
}
