using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Payments1
    {
        public int Employee = 1;

                                                   
        public static void main(string[] args)
        {

            Payments1 Payroll = new Payments1();
            Console.WriteLine("Welcome payroll");
            program Payments = new program();
            int menu = 1;

            do
            {
                Console.WriteLine 
                    ("\n1) add employee" +
                    " \n2) Exit the program.\n");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine($"employees {Payroll.Employee}");
                            Payments.Data();
                            Payments.Print();
                            Payments.FileData();

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("add correct number");
                            break;
                        }
                        
                }
                Payroll.Employee++;
            } while (menu != 2);


        }



    }
}

