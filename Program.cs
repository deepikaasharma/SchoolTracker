using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many students are in the class?");
            var studentCount= int.Parse(Console.ReadLine()); // have to parse because studentCount has to be in int not string. Readline is always string, so have to parse. 

            
            var StudentGrades = new int[studentCount] ; // using an array here but perhaps LinkedList would be better here. 
            var StudentNames = new string[studentCount];  //remember student Name is a string not an int.


            //following lets us input the value of student Names and Grades on the Console, and it iterates the array as long as i is less than studentCount. 
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("Student Name: ");
                StudentNames[i]= Console.ReadLine();

                Console.Write("Student Grade: ");
                StudentGrades[i] = int.Parse(Console.ReadLine());  // have to parse because we want grades in int, readline always has string as default.
            }


            //following writes names and grades for students with studentCount less than i, iterates as long as index is less than the studentCount. 
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($" Student {StudentNames[i]} 's grade is: {StudentGrades[i]} ");

            }

            //foreach (var studentgrade in StudentGrades)
            //{
            //    Console.WriteLine(studentgrade);

            //}


            
        }
    }
}
