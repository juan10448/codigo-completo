using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class program
    {

        Data data = new Data();
        public void Data()
        {
            
            Console.WriteLine("Insert Documen: ");
            data.Document1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Inser first name: ");
            data.FirstName1 = Console.ReadLine();
            Console.WriteLine("Insert Last Name: ");
            data.LastName1 = Console.ReadLine();
            Console.WriteLine("insert Salary");
            data.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("insert worked days: ");
            data.WorkedDays = double.Parse(Console.ReadLine());  
            Console.ReadKey();

            if (data.Salary <= 2_000_000)
            {
                data.TotalIcome1 = data.TotalIcome1 + data.Transport1;
            }
            else
            {
                data.TotalIcome1 = data.TotalIcome1;
            }
            data.TotalIcome1 = data.Salary * data.WorkedDays / 30;
            data.Pension = data.TotalIcome1 * 0.04;
            data.Healthe = data.TotalIcome1 * 0.04;
            data.Transport1 = 117_112 / 30;
            data.Transport1 = data.Transport1 * data.WorkedDays;
        }



        public void Print()
        {
            Console.WriteLine("Document: " + data.Document1);
            Console.WriteLine("First name: " + data.FirstName1);
            Console.WriteLine("Last name: " + data.LastName1);
            Console.WriteLine("salary: " + data.Salary);
            Console.WriteLine("worked days: " + data.WorkedDays);
            Console.WriteLine("tota icomes: " + data.TotalIcome1);
            Console.WriteLine("transport: " + data.Transport1);
            Console.WriteLine("pension: " + data.Pension);
            Console.WriteLine("healthe: " + data.Healthe);

        }



        public void FileData()
        {
           
            TextWriter File = new StreamWriter("FileData.txt", true);
            File.WriteLine($"Document: {data.Document1}");
            File.WriteLine($"First name: {data.FirstName1}");
            File.WriteLine($"Last name: {data.LastName1}");
            File.WriteLine($"salary:  { data.Salary}");
            File.WriteLine($"worked days:   {data.WorkedDays}");
            File.WriteLine($"tota icomes:   { data.TotalIcome1}");
            File.WriteLine($"transport:  {data.Transport1}");
            File.WriteLine($"pension:  {data.Pension}");
            File.WriteLine($"healthe:  {data.Healthe}");
            File.Close();
        }




    }




        
       











    }
    
