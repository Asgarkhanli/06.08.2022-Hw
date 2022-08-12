using System;

namespace _06._08._2022_Hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //Task_01

            int day = dayofweek(02, 04, 2003);
            Console.WriteLine(day);
        }

        static int dayofweek(int d, int m, int y)
        {
            int[] t = { 1, 4, 2, 5, 0, 4, 5 };

            y -= (m < 3) ? 1 : 0;

            return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;


            //    //Task_02

            DateTime myBirthday = DateTime.Parse("02/04/2003");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine("You are " + myAge.TotalDays + " days old!");
            Console.ReadLine();

            //Task_03

            int n1, n2, n3;

            n1 = 23;
            n2 = 25;
            n3 = 44;
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("Number one is the largest!\n");
                }
                else
                {
                    Console.WriteLine("Number three is the lagrest!\n");

                }
            }

            else if (n2 > n3)
                Console.WriteLine("Number two is the lagrest!\n");
            else
                Console.WriteLine("Number three is the lagrest!\n");


            //    //Task_04

            int dayno;

            Console.Write("\n\n");
            Console.Write("Accept day number and display its equivalent day name in word:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input Day No : ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:
                    Console.Write("Monday \n");
                    break;
                case 2:
                    Console.Write("Tuesday \n");
                    break;
                case 3:
                    Console.Write("Wednesday \n");
                    break;
                case 4:
                    Console.Write("Thursday \n");
                    break;
                case 5:
                    Console.Write("Friday \n");
                    break;
                case 6:
                    Console.Write("Saturday \n");
                    break;
                case 7:
                    Console.Write("Sunday \n");
                    break;
                default:
                    Console.Write("Invalid Day Number. \nPlease Try Again ...\n");
                    break;

            }

            //    //Task_05

            int num1, num2, opt;
            Console.Write("\n\n");
            Console.WriteLine("A menu driven prgram for a simple calculator : \n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Enter the first Integer :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Integer :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nHere are the options :\n");
            Console.Write("1.Addition. \n2.Subtraction. \n3.Multiplication. \n4.Division. \n5Exit. \n");
            Console.WriteLine("\nInput Your Choice :");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.Write("The Addition of {0} and {1} is: {2}\n", num1, num2, num1+num2);
                    break;

                    case 2:
                    Console.Write("The Substraction of {0} and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("The Multiplication of {0} and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    if(num2 == 0)
                    {
                        Console.Write("The second Integer is zero. devide by zero.\n");
                    }
                    else
                    {
                        Console.Write("The Division of {0} and {1} is: {2}\n", num1, num2, num1 / num2);
                    }
                    break;

                case 5:
                    break;

                    default:
                    Console.Write("Input Correct Option \n");
                        break;

            }


            //    //Task_06

            int n, r, sum = 0, temp;
            Console.Write("Enter the Number : ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.WriteLine("Number is not Palindrome.");

            //Task_07

            int num;
            Console.Write("\n\nFunction : To calculate the sum of the individual digits of a number :\n");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.Write("Enter a Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the numbers {0} is : {1}\n" ,num, TotalCal(num));
        }
        public static int TotalCal(int n)
        {
            string n1 = Convert.ToString(n);
            int total = 0;
            for (int i = 0; i < n1.Length; i++)
                total += Convert.ToInt32(n1.Substring(i, 1));
            return total;
        }
    }
}
