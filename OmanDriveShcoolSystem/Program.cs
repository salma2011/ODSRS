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
        while (true)
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


                    break;
                case 3:

                    BookingLesson bookingLesson = new BookingLesson();
                    bookingLesson.BookDrivingLesson(students, instructor, "", "", "", "");
                    break;
                case 4:


                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:

                    break;
                default:

                    break;

            }
        }
    }
}