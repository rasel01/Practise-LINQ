using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            //var stdList = from variable in std.GetStudentList()
            //              select  variable;

            // foreach (var stud in stdList)
            // {
            //     Console.WriteLine(stud.Name + stud.Age);   
            // }

            // Console.WriteLine("\n");

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
            // get all student list 
            // var studentListInfo = std.GetStudentList();
            //condition apply:
            //var studentListInfo = std.GetStudentList().Where(x => x.Age > 30 && x.Name =="Andrew");
            //order by asecending and decending order:
            //var studentListInfo = std.GetStudentList().Where(x => x.Age > 30).OrderByDescending(x=>x.Name);

            // count of the student(aggregate function)
           // int counting = std.GetStudentList().Count(x => x.Age > 30);
            //Console.WriteLine(counting);

             var studentListInfo = std.GetStudentList();
            Student firstValue = studentListInfo.FirstOrDefault();
            Console.WriteLine(firstValue.Name + ":" + firstValue.Age + ":" + firstValue.Id);

            var testArray = new[] {1,3,5,7,9};
            var testArray2 = new[] {"rasel","cell","belt"};
            //var value = testArray.FirstOrDefault(x => x % 2 == 0);
            var value = testArray2.FirstOrDefault(x=>x.Contains("cell"));
            Console.WriteLine(value);




            //foreach (var stude in studentListInfo)
            //{
            //    Console.WriteLine("name:" + stude.Name + " " + "age :" + " " + stude.Age + " " + "ID:" + " " + stude.Id);
            //}






            Console.ReadKey();
        }
    }
}
