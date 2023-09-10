namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            string story = $"{name} likes to rock out to {band} on their spare time. Their {animal} doesn't like listening to their music though. But, if you're wearing a {color} shirt they might let it slide.";
            Console.WriteLine(story);

            Add(1);
            Subtract(2);
            Multiply(3);
            Divide(4);
            Modulus(5);
        }

        public static int Add(int addition)
        {
            int results = 1 + addition;
            return results;
        }

        public static int Subtract(int subtraction)
        {
            int results = 2 - subtraction;
            return results;
        }

        public static int Multiply(int multiplication)
        {
            int results = 3 * multiplication;
            return results;
        }

        public static int Divide(int dividend)
        {
            int results = 2 / dividend;
            return results;
        }

        public static int Modulus(int modulus)
        {
            int results = 5 % modulus;
            return results;
        }
    }
}