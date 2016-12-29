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

            foreach (var stud in stdList)
            {
                Console.WriteLine(stud.Name + stud.Age);   
            }

            Console.WriteLine("\n");

            //Lamda Expression: full student list 

            //Console.WriteLine("full student list " + Environment.NewLine);
            //var studentList = std.GetStudentList();
            //foreach (var stude in studentList)
            //{
            //    Console.WriteLine(stude.Name + stude.Age);
            //}

            //Console.WriteLine("\n");

            //Lamda Expression: full student list for one condition age > 30

            Console.WriteLine("full student greater than 30 age: " + Environment.NewLine);
            var studentListInfo = std.GetStudentList().Where(x=>x.Age>30);
            foreach (var stude in studentListInfo)
            {
                Console.WriteLine("name:"+ stude.Name + " " + "age" + stude.Age + " " + "ID:" + " " + stude.Id);
            }




            Console.ReadKey();
        }
    }
}
