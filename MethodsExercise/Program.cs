namespace MethodsExercise
{
    public class Program
    {

        public static string GetUserAnswer(string question)
        {
            // Asker user the question printed to the console
            Console.WriteLine(question);
            // return user data into variable
            return Console.ReadLine();
        }

        public static int AddTwo(int x, int y)
        {
            return x + y;
        }

        public static int MinusTwo(int x, int y)
        {
            return x - y;
        }

        public static int MultiplyTwo(int x, int y)
        {
            return x * y;
        }

        public static int DivideTwo(int x, int y)
        {
            return x / y;
        }

        public static int RemainderOfTwo(int x, int y)
        {
            return x % y;
        }

        public static int AddAll(params int[] numberList)
        {
            int totalSum = 0;
            foreach (int num in numberList)
            {
                totalSum += num;
            }
            return totalSum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nExercise 1:\n");
            
            // Declaring variables and initializing it with GetUserAnswer() method to write the parameter question and store the returned data from the user
            string userName = GetUserAnswer("\tWhat is your name?").Trim();
            string userLeastFavCity = GetUserAnswer("\tWhat is your LEAST favorite city?").Trim();
            string userColor = GetUserAnswer("\tWhat color is the shirt that you're wearing right now?").ToLower().Trim();
            string userFavAnimal = GetUserAnswer("\tWhat is your favorite animal?").ToLower().Trim();

            
            Console.WriteLine
                (
                $"\n\tStory:\n\t\t{userName} was walking in downtown {userLeastFavCity}.\n\t\tThey noticed a tree painted {userColor} and decided to climb it.\n" +
                $"\t\tUnfortunately, {userName} fell from the {userColor} tree and broke their back.\n\t\tIf {userName} was a {userFavAnimal},\n" +
                $"\t\tthey probably would have been fine from the fall.\n\t\t{userLeastFavCity} is a terrible city."
                );
            

            Console.WriteLine("\nExercise 2:\n");
            Console.WriteLine($"\t2 + 8 = {AddTwo(2, 8)}\n\t200 - 50 = {MinusTwo(200, 50)}\n\t4 x 7 = {MultiplyTwo(4, 7)}\n\t20 / 5 = {DivideTwo(20, 5)}\n\t20 / 7 gives a remainder of {RemainderOfTwo(20, 7)}");


            Console.WriteLine("\nChallenge:\n");
            Console.WriteLine($"\t2 + 3 + 3 + 7 = {AddAll(2, 3, 3, 7)}");

        }
    }
}