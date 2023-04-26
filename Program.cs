namespace Prog_120_S23_L7_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Left vs the Right side
            //Console.WriteLine("37" > "23");

            //// Condition
            //int numberOfHairs = 100000;
            //int fullHeadOfHair = 50000;

            //// if  / else
            //// Comparing how many hairs I have on my head, to how many are on a full head of hair
            //bool willHasHair = numberOfHairs >= fullHeadOfHair;

            //Console.WriteLine("Before our if statement");
            //if (willHasHair) // Will only run if the condition is true
            //{
            //    Console.WriteLine("Has a full head of hair");
            //} // After if
            //else // This only runs if our IF is false
            //{
            //    Console.WriteLine("That guy has a shiny head");
            //}

            double customersWaterGlass = .7;
            double whenToRefill = .5;

            // If else is always two choices, If or else

            if(customersWaterGlass < whenToRefill) // This checks Everything BENEATH .5
            {
                string customerName = "Will";
                Console.WriteLine("Would you like me to refill your glass?");
                customersWaterGlass = .9;
            }
            else if (customersWaterGlass <= .7) // This chaecks between .5 AND .7
            {
                
                Console.WriteLine("How is your meal");
            }
            else
            {
                Console.WriteLine("Would you like me to get you the bill");
            }


            Console.WriteLine($"Customers water glass is at {customersWaterGlass}");
            Console.WriteLine("After our if statement");

        } // Main

        public static void Example()
        {


            // The variable to hold true or false, is the boolean
            // also defined with bool

            // string, int, double, bool
            //string whatYouTypedIn = "Will";
            //string userName = "Will";

            // Comparsion Operators
            // Equals == : Compare two values to see if they are the same
            // True: If the two values are EXACTLY the same
            // With double equals ONLYE ONE THING will ever be true
            Console.WriteLine("Equals ==: ");
            bool isTrue = true;
            bool isFalse = false;

            Console.WriteLine($"{isTrue} == {isTrue} : {isTrue == isTrue}");
            Console.WriteLine($"{isFalse} == {isFalse} : {isFalse == isFalse}");
            Console.WriteLine($"{isTrue} == {isFalse} : {isTrue == isFalse}");
            Console.WriteLine("Double equals works on all variables: string, int, double, bool, etc...");

            Console.WriteLine();
            // Doesn't Not Equal != : Compare to values to see if they are different
            // True: If they are completely Different 
            // Everything But ONE THING will be True
            Console.WriteLine("Does not equal");
            Console.WriteLine($"{isTrue} != {isTrue} : {isTrue != isTrue}");
            Console.WriteLine($"{isFalse} != {isFalse} : {isFalse != isFalse}");
            Console.WriteLine($"{isTrue} != {isFalse} : {isTrue != isFalse}");
            Console.WriteLine("Not equals works with all variables");


            Console.WriteLine("Please enter your user name: ");
            string userInput = Console.ReadLine();
            string userName = "Benel";
            bool compareLoginToUserName = userInput == userName; // bool only holds true or false
            // Comparison operators ALL return true or false, and they ALL compare values

            // Comparison operators are CASE SENSITIVE
            // benel is not the same as Benel : This returns false
            // Benel is the same as Benel : This returns false
            //bool twoDifferentTypes = 10 == "10"; // Need to be the same type

            if (compareLoginToUserName)
            {
                Console.WriteLine("Thank you for logging in");
            }

            // Condition
            // Logic
            // if keyword

            // if (boolean) {
            // your code
            //}
            // when i put false in the if statement, Hello World didn't display


            // These operators only work on numbers
            // Less Than <
            // Greater Than >
            // Less Tan OR Equal to <=
            // Greather Than or Equal To >=
            int benelFav = 77;
            int moFav = 78;
            int willFav = 79;
            int nancyFav = 16;
            Console.WriteLine(55 >= 55);
            Console.WriteLine(55 > 54);
        }

    } // class

} // namespace