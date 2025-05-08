using OmanDriveShcoolSystem.Model;

public class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("===================================================");
        Console.WriteLine("Nizwa Driving School System");
        Console.WriteLine("===================================================\n");
        List<Student> students = new List<Student>();
        int studentCounter = 1;

        List<Instructor> instructor = new List<Instructor>();
        int instruccounter = 1;


        List<BookingLesson> bookingLessons = new List<BookingLesson>();
        bool isRunning = true;
        while (isRunning)
        {

            Console.WriteLine("1 . Register New Student");
            Console.WriteLine("2 . Register New Instructor");
            Console.WriteLine("3 . Book Driving Lesson");
            Console.WriteLine("4 . Record Lesson Completion & Instructor Feedback");
            Console.WriteLine("5 . View Student Lesson History");
            Console.WriteLine("6 . View All Scheduled Lessons");
            Console.WriteLine("7 . Exit!");

            Console.Write("\nSelect an Option : ");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Console.WriteLine("\n-- Register New Student --");
                    Student.addStudent(students, ref studentCounter);
                    break;
                case 2:
                    Console.WriteLine("\n-- Register New Instructor --");
                    Instructor.addInstroctur(instructor, ref instruccounter);

                    break;
                case 3:
                    Console.WriteLine("\n-- Book Driving Lesson --");
                    BookingLesson bookingLesson = new BookingLesson();
                    bookingLesson.BookDrivingLesson(students, instructor, "", "", "", "");
                    break;
                case 4:
                    Console.WriteLine("\n-- Record Lesson Completion & Feedback --");

                    break;
                case 5:
                    Console.WriteLine("\n-- View Student Lesson History --");
                    break;
                case 6:
                    Console.WriteLine("\n-- View All Scheduled Lessons --");
                    break;
                case 7:

                    isRunning = false;
                    Console.WriteLine("\nThank you for using Nizwa Driving School System. Goodbye!");

                    break;
                default:
                    Console.WriteLine("\nChoose Corecct Number!\n");
                    break;

            }
        }
    }
}