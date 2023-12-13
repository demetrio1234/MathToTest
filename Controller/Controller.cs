using MathToTest.Model;

namespace MathToTest.Controller
{
    public class Controller
    {
        private MathClass mathClass;
        private string[] arguments = ["", "", "", ""];
        public Controller()
        {
            mathClass = new MathClass();
        }

        public string[] GetArguments()
        {
            return arguments;
        }

        public void GetAndAssignParameters()
        {
            try
            {
                GetOperation();

                GetFirstOperand();

                GetSecondOperand();

                AssignParameters();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void GetOperation()
        {
            try
            {
                Console.WriteLine("Enter the first parameter:\n--a for addition operation\n--s for subtraction operation\n--m for multiplication operation\n--d for division operation\n");

                switch (Console.ReadLine())
                {
                    case "--d":
                        arguments[1] = "--d";
                        break;
                    case "--m":
                        arguments[1] = "--m";
                        break;
                    case "--s":
                        arguments[1] = "--s";
                        break;
                    case "--a":
                        arguments[1] = "--a";
                        break;
                    default:
                        Console.WriteLine("Please enter a valid operator as first parameter:--a for addition operation\n--s for subtraction operation\n--m for multiplication operation\n--d for division operation ");
                        GetOperation();
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void GetFirstOperand()
        {
            try
            {
                Console.WriteLine("Enter the second parameter aka first operand:");
                arguments[2] = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void GetSecondOperand()
        {
            try
            {
                Console.WriteLine("Enter the third parameter aka second operand:");
                arguments[3] = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void AssignParameters()
        {
            try
            {
                mathClass.FirstOperand = float.Parse(arguments[2]);
                mathClass.SecondOperand = float.Parse(arguments[3]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void Operate()
        {
            try
            {
                switch (arguments[1])
                {
                    case "--d":
                        Console.WriteLine(mathClass.DivideFirstOperandBySecondOperand());
                        break;
                    case "--m":
                        Console.WriteLine(mathClass.MultiplyFirstOperandBySecondOperand());
                        break;
                    case "--s":
                        Console.WriteLine(mathClass.SubtractFirstOperandBySecondOperand());
                        break;
                    case "--a":
                        Console.WriteLine(mathClass.AddFirstOperandBySecondOperand());
                        break;
                    default:
                        Console.WriteLine("Please enter a valid operation.");//Should never run
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}