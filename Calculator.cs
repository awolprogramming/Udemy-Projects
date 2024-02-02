namespace Udemy
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! \nWrite the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Write the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to do? \n [A]dd numbers \n [S]ubtract numbers \n [M]ultiply numbers");
            string chosenProperty = Console.ReadLine().ToLower();
            string chosenOperator;
            int result;

            if (chosenProperty != "a" && chosenProperty != "s" && chosenProperty != "m") {
                Console.WriteLine("Wrong property!");
                return;
            }

            switch (chosenProperty)
            {
                case "a":
                    chosenOperator = "+";
                    result = firstNumber + secondNumber;
                    break;
                case "s":
                    chosenOperator = "/";
                    result = firstNumber / secondNumber;
                    break;
                case "m":
                    chosenOperator = "*";
                    result = firstNumber * secondNumber;
                    break;
                default:
                    chosenOperator = "+";
                    result = firstNumber + secondNumber;
                    break;
            }

            Console.WriteLine(firstNumber + " " + chosenOperator + " " + secondNumber + " = " + result);

            Console.ReadKey();
        }
    }
}