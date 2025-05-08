using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OmanDriveShcoolSystem.Model
{
    internal class BookingLesson
    {

        public string studentId { get; set; }
        public string InstructorID { get; set; }

        public string date { get; set; }

        public string time { get; set; }

        
        public void BookDrivingLesson(List<Student> students, List<Instructor> instructors, string studentId, string InstructorID, string date, string time)
        {


            Console.WriteLine("-- Book Driving Lesson --\n");


            Console.Write("Enter Student ID: ");
            studentId = Console.ReadLine();

            // Check if the student ID exists

           while (!students.Any(s => s.studentId == studentId))
           {
              Console.WriteLine("\nStudent ID not found. Please try again.\n");
              Console.Write("Enter Student ID: ");
              studentId = Console.ReadLine();
           }


            while (!instructors.Any(ins => ins.InstructorID == InstructorID))
            {
                Console.WriteLine("\nInstructor ID not found. Please try again.\n");
                Console.Write("\nEnter Instructor ID: ");
                InstructorID = Console.ReadLine();
            }

            Console.Write("\nEnter Instructor ID: ");
            InstructorID = Console.ReadLine();


            Console.Write("\nEnter Lesson Date (dd/mm/yyyy): ");
            date = Console.ReadLine();

            while (!Regex.IsMatch(date, @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$")) {

                Console.WriteLine("\nEnter In This Format (dd/mm/yyyy)");
                Console.Write("Enter Lesson Date (dd/mm/yyyy): ");
                date = Console.ReadLine();
            }



            Console.Write("\nEnter Time (HH:mm): ");
            time = Console.ReadLine();

            while (!Regex.IsMatch(time, @"^(?:[01]\d|2[0-3]):[0-5]\d$"))
            {

                Console.WriteLine("\nEnter In This Format (HH:mm)");
                Console.Write("Enter Time (HH:mm): ");
                time = Console.ReadLine();
            }

            


            Console.WriteLine("\nLesson scheduled successfully\n");



        }

    }
}
