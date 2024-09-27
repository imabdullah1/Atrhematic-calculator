using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class Program
    {


        public static void Addition(int x , int y)
        {
            int Result = x + y; 
            Console.WriteLine("The Result of Addition is :{0}", Result);
        }
        public static void Subtracction(int x, int y)
        {
            int Result = x - y;
            Console.WriteLine("The Result of Subtraction is :{0}", Result);

        }
        public static void Multiplication(int x, int y)
        {
            int Result = x * y;
            Console.WriteLine("The Result of Multiplication is :{0}", Result);

        }
        public static void Divison(int x, int y)
        {
            int Result = x / y;
            Console.WriteLine("The Result of Divison is :{0}", Result);

        }
        public static void Modulus(int x, int y)
        {
            int Result = x % y;
            Console.WriteLine("The Result of Modulus is :{0}", Result);

        }
        static void Main(string[] args)
        {



            Console.WriteLine("Enter the First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            int num2 = int.Parse(Console.ReadLine());


            string Op = Console.ReadLine();


            ///ARTHEMATIC  CALCULATOR WITH IF-ELSE CONDITION///


            if (Op == "+")
            {
                Program.Addition(num1, num2);
            }
            else if (Op == "-")
            {
                Program.Subtracction(num1, num2);

            }
            else if (Op == "*")
            {
                Program.Multiplication(num1, num2);
            }
            else if (Op == "/") 
            {
                Program.Divison(num1, num2);
            }
            else if (Op == "%")
            {
                Program.Divison(num1, num2);
            }





            ///ARTHEMATIC CALCULATOR WITH SWITCH CASES STATEMENTS CONDITION///



            //switch (op)
            //{
            //    case '+': Program.Addition(num1, num2);
            //        break;

            //    case '-':
            //        Program.Subtracction(num1, num2);
            //        break;

            //    case '*':
            //        Program.Multiplication(num1, num2);
            //        break;

            //    case '/':
            //        Program.Divison(num1, num2);
            //        break;
            //      case '%':
            //            Program.Divison(num1, num2);
            //           break;
            
            //}



                Console.ReadLine();







        }
    }
}
