namespace IterationStatements
{
    public class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i <= 999; i += 3)
                {
                Console.WriteLine(i);
                }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int number)
        {
            if  (number % 2 == 0)
                {
                return true;
                }
            else
            {
                return false;
            }
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.

        public static bool IsPositive(int number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number)
        {
            if (number <= 10 && number >= -10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {number} = {i * number}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            PrintNumbers(); //call lukewarm 1
            PrintEveryThirdNumber(); //call lukewarm 2
            AreNumbersEqual(2, 3); //call lukewarm 3
            IsEven(2); //call lukewarm 4
            IsPositive(3); //call lukewarm 5
            CanVote(19); //call lukewarm 6
            
            Console.WriteLine("Please enter a number:");    //call of heatin up 1
            IsInRange(int.Parse(Console.ReadLine()));

            DisplayMultiplicationTable(17);          //call for heatin up 2

        }   
    }
}
