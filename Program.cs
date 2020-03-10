using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<student>();
            //Console.WriteLine("How many students are in the class?");
            //var studentCount= int.Parse(Console.ReadLine()); // have to parse because studentCount has to be in int not string. Readline is always string, so have to parse. 


            //var StudentGrades = new int[studentCount] ; // using an array here but perhaps LinkedList would be better here. 
            //var StudentNames = new string[studentCount];  //remember student Name is a string not an int.

            ////we are using Linked Lists now:
            //var StudentNames = new List<string>();
            //var StudentGrades = new List<int>();

            // Now we need a way to add indefinite amount of students to the class, so we will use the while loop and copy the logic from the for loop.

            var adding = true;

            //while (adding)  // while we are adding, do the following
            //{
            //    Console.Write("Student Name: ");
            //    StudentNames.Add(Console.ReadLine());

            //    Console.Write("Student Grade: ");
            //    StudentGrades.Add(int.Parse(Console.ReadLine()));  // have to parse because we want grades in int, readline always has string as default.

            //    Console.WriteLine("Add Another? Y/N ");
            //    if (Console.ReadLine() != "Y")
            //    {
            //        adding = false;
            //    }
            //}

            while (adding)  // while we are adding, do the following
            {
                var newstudent = new student();
                Console.Write("Student Name: ");
                newstudent.Name= Console.ReadLine();

                Console.Write("Student Birthday: ");
                newstudent.Birthday = Console.ReadLine();

                Console.Write("Student Address: ");
                newstudent.Address = Console.ReadLine();

                Console.Write("Student Phone Number: ");
                newstudent.PhoneNumber = int.Parse(Console.ReadLine());

                Console.Write("Student Grades: ");
                newstudent.Grades =(int.Parse(Console.ReadLine()));  // have to parse because we want grades in int, readline always has string as default.

                students.Add (newstudent);

                Console.WriteLine("Add Another? Y/N ");
                if (Console.ReadLine() != "Y")
                {
                    adding = false;
                }
            }

            ////following lets us input the value of student Names and Grades on the Console, and it iterates the array as long as i is less than studentCount. 
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write("Student Name: ");
            //    StudentNames[i]= Console.ReadLine();

            //    Console.Write("Student Grade: ");
            //    StudentGrades[i] = int.Parse(Console.ReadLine());  // have to parse because we want grades in int, readline always has string as default.
            //}

            ////following writes names and grades for students with studentCount less than i, iterates as long as index is less than the studentCount. 
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($" Student {StudentNames[i]} 's grade is: {StudentGrades[i]} ");

            //}
            //following writes names and grades for students with studentCount less than i, iterates as long as index is less than the studentCount. 
            //for (int i = 0; i < StudentNames.Count; i++)
            //{
            //    Console.WriteLine($" Student {StudentNames[i]} 's grade is: {StudentGrades[i]} ");

            //}

            //because we have list we don't need for loop, we will use foreach?  /*Phone Number: {student.setPhone}*

            foreach (var student in students)
            {
                Console.WriteLine($" Student: {student.Name}  Birthday: {student.Birthday} Address: {student.Address}  Grades: {student.Grades} ");
            }

            //foreach (var studentgrade in StudentGrades)
            //{
            //    Console.WriteLine(studentgrade);

            //}


        }
    }

    // if we want to add bithdate, address, phone number of the student in addition to the name and grade, we will have too many lists, so instead we will create a class called student that has these attributes. This is where we use the OOP.
    class student
    {
        public string Name;
        public string Birthday;
        public string Address;
        public int Grades;
        private int phoneNumber;

        public int PhoneNumber
        {
            set { phoneNumber = value; } 
                
        }

        public void setPhone(int number)
        {
            phoneNumber = number;
        }

    }
}


