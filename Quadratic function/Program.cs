using System;

namespace Quadratic_function
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadratic_function_solver();
        }

        static void Quadratic_function_solver()
        {
            //input the equation and make some changes
            Console.WriteLine("Write the equation:\n");
            string equation = Console.ReadLine();
            equation = equation.Substring(equation.IndexOf("=") + 1);
            equation = equation.Replace(" ", String.Empty);

            

            equation = equation.Insert(0, "       ");


            double a = 0;
            double b = 0;
            double b2 = 0;
            double c = 0;
            bool checker = false;
            bool checker2 = true;

            int index = equation.IndexOf("x^2");

            //this -if- checks if before before the end of the equation is a number
            if (Char.IsDigit(equation[equation.Length - 2]))
            {

                //here you add the number that is before before the end of the equation to -c- variable and then multiply it by 10 and then add the number before the end of the equation
                //I multiply it by 10 because if before before the end of the equation there is a number then that means that before the end of the equation there is a number too so
                //that means that -b- variable should be two digit number
                c = Char.GetNumericValue(equation[equation.Length - 2]);
                c *= 10;
                c += Char.GetNumericValue(equation[equation.Length - 1]);

                //this -if- checks if -c- variable shoud be negative
                if (equation[equation.Length - 3] == '-')
                {
                    c = -c;
                }
            }
            else
            {
                //here the number before the end of the equation get added to -c- variable and the -if- checks if number is negative and if it is -c- variable becomes negative
                c = Char.GetNumericValue(equation[equation.Length - 1]);
                checker2 = true;
                if (equation[equation.Length - 2] == '-')
                {
                    c = -c;
                }
            }

            //this -if- statement is used when the equation is y=x^2 or y=-x^2 or y=2x^2
            if (equation[equation.Length - 2] == '^')
            {
                c = 0;
            }

            if (equation[equation.Length - 2] == '^' || equation[equation.Length - 1] == 'x')
            {
                //this variable is what Differentiates between c = -1 because in the equation it is -1 and c = -1 becausee there is no c in the equation 
                checker2 = false;
            }

            //this -if- checks if c = -1 and if it is c value becoms 0
            if (c == -1)
            {
                //this -if- checks if c = -1 because in the equation it is -1 or c = -1 becausee there is no c in the equation 
                if (checker2 == false)
                {
                    c = 0;
                }
            }


            //this -if- statement will get the value of a in the equation
            //the first -if- checks if before x^2 there is Subtraction then that means that a = -1
            if (equation[index - 1] == '-')
            {
                a = -1;
            }

            //the -else if- checks if before x^2 there is Sum or an empty space then that means that a = 1
            //this -if- also checks if before x^2 there is an empty space because if it was at the start of the equation you don`t type + before it you leave without any operations
            else if (equation[index - 1] == '+' || equation[index - 1] == ' ')
            {
                a = 1;
            }

            //this -else if- checks if the place before before x^2 is a number
            else if (Char.IsDigit(equation[index - 2]))
            {
                //here you add the number that is before before x^2 to -a- variable and then multiply it by 10 and then add the number before x^2
                //I multiply it by 10 because if before before x^2 there is a number then that means that before x^2 there is a number too so
                //that means that -a- variable should be two digit number
                a = Char.GetNumericValue(equation[index - 2]);
                a *= 10;
                a += Char.GetNumericValue(equation[index - 1]);

                //this -if- checks if -a- variable shoud be negative
                if (equation[index - 3] == '-')
                {
                    a = -a;
                }
            }

            else
            {
                //here the number before x^2 get added to -a- variable and the -if- checks if number is negative and if it is -a- variable becomes negative
                a = Char.GetNumericValue(equation[index - 1]);
                if (equation[index - 2] == '-')
                {
                    a = -a;
                }
            }


            //this -if- and -else if- and -else- checks the value of -a- and based on that it remove ax^2 from the equation
            if (a == -1)
            {
                equation = equation.Replace("-x^2", String.Empty);
            }
            else if (a == 1)
            {
                equation = equation.Replace("x^2", String.Empty);
            }
            else
            {
                equation = equation.Replace(a + "x^2", String.Empty);
            }


            index = equation.IndexOf('x');

            //this -if- check if index = -1 and if index = -1 that means that -x- isn`t in this equation then that means that b = 0
            if (index == -1)
            {
                b = 0;
            }else
            {

                //this -if- checks if before x there is a Subtraction and that means that b = -1
                if (equation[index - 1] == '-')
                {
                    b = -1;
                }

                //the -else if- checks if before x there is Sum or an empty space then that means that b = 1
                //this -if- also checks if before x there is an empty space because if it was at the start of the equation you don`t type + before it you leave without any operations
                else if (equation[index - 1] == ' ' || equation[index - 1] == '+')
                {
                    b = 1;
                }

                //this -else if- checks if before before x is a number
                else if (Char.IsDigit(equation[index - 2]))
                {

                    //here you add the number that is before before x to -b- variable and then multiply it by 10 and then add the number before x
                    //I multiply it by 10 because if before before x there is a number then that means that before x there is a number too so
                    //that means that -b- variable should be two digit number
                    b = Char.GetNumericValue(equation[index - 2]);
                    b *= 10;
                    b += Char.GetNumericValue(equation[index - 1]);

                    //this -if- checks if -a- variable shoud be negative
                    if (equation[index - 3] == '-')
                    {
                        b = -b;
                    }
                }
                else
                {
                    //here the number before x get added to -b- variable and the -if- checks if number is negative and if it is -b- variable becomes negative
                    b = Char.GetNumericValue(equation[index - 1]);
                    if (equation[index - 2] == '-')
                    {
                        b = -b;
                    }
                }


                //this -if- and -else if- and -else- checks the value of -b- and based on that it remove bx from the equation
                if (b == -1)
                {
                    equation = equation.Replace("-x", String.Empty);
                }
                else if (b == 1)
                {
                    equation = equation.Replace("x", String.Empty);
                }
                else
                {
                    equation = equation.Replace(b + "x", String.Empty);
                }
            }



            //print the value of a and b and c
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);
            Console.WriteLine("-----------------------\n");

            //check if b is negative and if it is b2 value becomes b absolute 
            if (b < 0)
            {
                b2 = Math.Abs(b);
            }
            //if b isn`t negative b2 becomes negative b
            else
            {
                b2 = -b;
            }

            //check if the Quadratic function collide with x-axis
            //I check by checking if the number that is going to be Squared is negative and if it is print that it doesn`t collides with x-axis
            //because you can`t sqrt a negative number
            if (Math.Pow(b, 2) - 4 * a * c < 0)
            {
                Console.WriteLine("this Quadratic function doesn't collide with x-axis\n\n\n");
            }
            //the program enter this -else- if the number is positive
            else
            {
                //here I start with the first point that collides with x-axis
                //and solve the equation and show the stages
                Console.WriteLine("x1/2 = (-b+√b²-4ac)/2a\n");
                Console.WriteLine("x1 = " + b2 + "+(√" + b + "²" + "-4" + "*" + a + "*" + c + ")/2*" + a);
                Console.WriteLine("x1 = " + b2 + "+(√" + Math.Pow(b, 2) + "-4" + "*" + a + "*" + c + ")/2*" + a);

                //checks if a and c is negative if they are checker = true
                //if just one of them is negative checker = false
                if (a < 0 && c < 0)
                {
                    checker = true;
                }
                else if (a < 0 || c < 0)
                {
                    checker = false;
                }

                //check if checker is true
                //if it is true that means that -4*a*c is going to be negative and I won`t be needing to add an operation
                //if it is false that means that -4*a*c is going to be positive and it won`t type Sum operation so I add a Sum operation myself 
                if (checker)
                {
                    Console.WriteLine("x1 = " + b2 + "+(√" + Math.Pow(b, 2) + -4 * a * c + ")/2*" + a);
                }
                else
                {
                    Console.WriteLine("x1 = " + b2 + "+(√" + Math.Pow(b, 2) + "+" + -4 * a * c + ")/2*" + a);
                }

                //continue solving the equation
                double result = Math.Pow(b, 2) + -4 * a * c;
                Console.WriteLine("x1 = " + b2 + "+(√" + result + ")/2*" + a);
                Console.WriteLine("x1 = (" + b2 + "+" + Math.Sqrt(result) + ")/2*" + a);
                result = b2 + Math.Sqrt(result);
                Console.WriteLine("x1 = " + result + "/2*" + a);
                Console.WriteLine("x1 = " + result + "/" + 2 * a);
                result /= 2 * a;
                Console.WriteLine("x1 = " + result + "\nx1(" + result + ",0)");



                Console.WriteLine("\n\n");
                //here I start with the second point that collides with x-axis
                Console.WriteLine("x2 = " + b2 + "-(√" + b + "²" + "-4" + "*" + a + "*" + c + ")/2*" + a);
                Console.WriteLine("x2 = " + b2 + "-(√" + Math.Pow(b, 2) + "-4" + "*" + a + "*" + c + ")/2*" + a);


                //check if checker is true
                //if it is true that means that -4*a*c is going to be negative and I won`t be needing to add an operation
                //if it is false that means that -4*a*c is going to be positive and it won`t type Sum operation so I add a Sum operation myself 
                if (checker)
                {
                    Console.WriteLine("x2 = " + b2 + "-(√" + Math.Pow(b, 2) + -4 * a * c + ")/2*" + a);
                }
                else
                {
                    Console.WriteLine("x2 = " + b2 + "-(√" + Math.Pow(b, 2) + "+" + -4 * a * c + ")/2*" + a);
                }

                //continue solving the equation
                result = Math.Pow(b, 2) + -4 * a * c;
                Console.WriteLine("x2 = " + b2 + "-(√" + result + ")/2*" + a);
                Console.WriteLine("x2 = (" + b2 + "-" + Math.Sqrt(result) + ")/2*" + a);
                result = b2 - Math.Sqrt(result);
                Console.WriteLine("x2 = " + result + "/2*" + a);
                Console.WriteLine("x2 = " + result + "/" + 2 * a);
                result /= 2 * a;
                Console.WriteLine("x2 = " + result + "\nx2(" + result + ", 0)\n\n");
            }
            Console.WriteLine("it collides with y axis at (0," + c + ")\n\n\n");


            //checks if a is negative and if it is that means that this Quadratic function has a max point
            if (a < 0)
            {
                //find the max point to the Quadratic function
                double x_max = -b / (2 * a);
                double y_max = a * Math.Pow(x_max, 2) + b * x_max + c;
                Console.WriteLine("the maximum point is:\n");
                Console.WriteLine("(" + x_max + "," + y_max + ")");
            }

            //if a is positive that means that this Quadratic function has a min point
            else if (a > 0)
            {
                //find the min point to the Quadratic function
                double x_min = -b / (2 * a);
                double y_min = a * Math.Pow(x_min, 2) + b * x_min + c;
                Console.WriteLine("the minimum point is:\n");
                Console.WriteLine("(" + x_min + "," + y_min + ")");
            }

            Console.WriteLine("-------------------\n\n");
            //go to the main method
            Main(null);
        }
    }
}
