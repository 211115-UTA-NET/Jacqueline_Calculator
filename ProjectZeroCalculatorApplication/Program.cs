using System;

namespace calculatorApp
{
    class CalculatorProgram
    {
        public static void Main(string[] args)
        {

            int number1;
            int number2;
            int answer;
            int temp = 0;

            var exit = true;
            do
            {

                Console.WriteLine("\nEnter first number: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\nPick an operation to be performed from the list :");
                Console.WriteLine("\n + For Addition ");
                Console.WriteLine(" - For Subtraction ");
                Console.WriteLine(" *  For Multiplication ");
                Console.WriteLine(" / For Divition ");
                Console.WriteLine(" % For Modulo ");
                Console.WriteLine("Swap For Swapping ");
                Console.WriteLine("Exit For stopping\n ");

                try
                {
                    string operationTobePerformed = Convert.ToString(Console.ReadLine());

                    switch (operationTobePerformed)
                    {
                        case "+":
                            answer = number1 + number2;
                            Console.WriteLine(" {0} {1} {2} " + "=" + " {3}", number1, operationTobePerformed, number2, answer);
                            break;
                        case "-":
                            answer = number2 - number1;
                            Console.WriteLine(" {0} {1} {2} " + "=" + " {3}", number2, operationTobePerformed, number1, answer);
                            break;
                        case "*":
                            answer = number1 * number2;
                            Console.WriteLine(" {0} {1} {2} " + "=" + " {3}", number1, operationTobePerformed, number2, answer);
                            break;
                        case "/":
                            try
                            {
                                if (number1 > number2)
                                {
                                    answer = number1 / number2;
                                    Console.WriteLine(" {0} {1} {2} " + "=" + " {3}", number1, operationTobePerformed, number2, answer);
                                }
                                else
                                {
                                    answer = number2 / number1;
                                    Console.WriteLine(" {0} {1} {2} " + "=" + " {3}", number2, operationTobePerformed, number1, answer);

                                }
                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine(ex.ToString());
                            }

                            break;
                        case "%":
                            answer = number1 % number2;
                            Console.WriteLine(" {0} {1} {2} " + "=" + " {3}", number1, operationTobePerformed, number2, answer);
                            break;
                        case "Swap":

                            temp = number1;
                            number1 = number2;
                            number2 = temp;
                            Console.WriteLine(" The Swapped numbers are {0} {1} ", number1, number2);
                            break;
                        case "Exit":
                            exit = false;
                            break;

                    }
                }catch (Exception ex) { Console.WriteLine(ex.Message); }


        } while (exit); 
        }

    }
}

