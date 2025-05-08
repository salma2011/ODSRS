using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanDriveShcoolSystem.Model
{



    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentCounter = 1;

            List<Instructor> instructor = new List<Instructor>();
            int instruccounter = 1;


            List<BookingLesson> bookingLessons = new List<BookingLesson>();

            Console.WriteLine("Welcome to Oman Driving School Registration System !!");
            while (true)
            {

                Console.WriteLine("1 . Register New Student");
                Console.WriteLine("2 . Register New Instructor");
                Console.WriteLine("3 . Book Driving Lesson");
                Console.WriteLine("4 . Record Lesson Completion & Instructor Feedback");
                Console.WriteLine("5 . View Student Lesson");
                Console.WriteLine("6 . View All Scheduled Lessons");
                Console.WriteLine("7 . Exit!!");

                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("Select an Option : 1");
                        Student.addStudent(students, ref studentCounter);
                        break;
                    case 2:
                        Console.WriteLine("Select an Option : 2");
                        Instructor.addInstroctur(instructor, ref instruccounter);
                        break;
                    case 3:
                        Console.WriteLine("Select an Option : 3");
                        BookingLesson bookingLesson = new BookingLesson();
                        bookingLesson.BookDrivingLesson(students, instructor, bookingLessons);

                        break;
                    case 4:
                        Console.WriteLine("Select an Option : 4");
                        BookingLesson.RecordLessonFeedback(bookingLessons);
                        break;
                    case 5:
                        Console.WriteLine("Select an Option : 5");
                        BookingLesson.ViewStudentLessons(bookingLessons, students, instructor);

                        break;
                    case 6:
                        Console.WriteLine("Select an Option : 6");
                        BookingLesson.ViewAllScheduledLessons(bookingLessons, students, instructor);
                        break;
                    case 7:
                        Console.WriteLine("Select an Option : 7");
                        Console.WriteLine("Exit");
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }
            }
        }
    }
}