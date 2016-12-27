using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            // old process using Foreach loop :

            //foreach (Student stud in std.GetStudentList())
            //{
            //    Console.WriteLine("Student ID :"+stud.Id+ Environment.NewLine 
            //        +"Student Name:" + stud.Name + Environment.NewLine + "Student Age :" + stud.Age + Environment.NewLine);
            //}



            // LINQ Process :
              
            // SQL LIKE SYNTAX:

           var stdList = from variable in std.GetStudentList()
                         select  variable;
            Console.WriteLine(stdList);


            Console.ReadKey();
        }
    }
}
