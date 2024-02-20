namespace SelStatementsDemoCSharp_45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if-else

            bool condition = true;

            if(condition == false)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("Fallback");
            }


            int a = 200;
            int b = 20;

            if(a == b)
            {
                Console.WriteLine("A and B are the same");
            }
            else if(b < a && a == 200)
            {
                Console.WriteLine("Special case");
            }
            else
            {
                Console.WriteLine("None of these were true");
            }

            // Ternary operator (inline if)

            int i = 1;

            string message = i > 0 ? "Positive" : "Zero";

            Console.WriteLine(message);

            //switch case

            string today = "Tuesday";

            switch(today)
            {
                case "Sunday":
                case "Sun":
                    Console.WriteLine("It is Sunday!");
                    break;
                case "Monday":
                    Console.WriteLine("It is Monday!");
                    break;
                case "Tuesday":
                    Console.WriteLine("It is Tuesday!");
                    break;
                case "Wednesday":
                    Console.WriteLine("It is Wednesday, my dudes!");
                    break;
                case "Thursday":
                    Console.WriteLine("It is Thursday!");
                    break;
                case "Friday":
                    Console.WriteLine("It is Friday!");
                    break;
                case "Saturday":
                    Console.WriteLine("It is Saturday!");
                    break;
                default:
                    Console.WriteLine("That is not a day of the week!");
                    break;
            }
        }
    }
}
