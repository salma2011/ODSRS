using OmanDriveShcoolSystem.Model;

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

                    break;
                case 3:
                    Console.WriteLine("Select an Option : 3");
                    BookingLesson bookingLesson = new BookingLesson();
                    bookingLesson.BookDrivingLesson(students, instructor, "", "", "", "");
                    break;
                case 4:
                    Console.WriteLine("Select an Option : 4");

                    break;
                case 5:
                    Console.WriteLine("Select an Option : 5");
                    break;
                case 6:
                    Console.WriteLine("Select an Option : 6");
                    break;
                case 7:
                    Console.WriteLine("Select an Option : 7");
                    break;
                default:

                    break;

            }
        }
    }
}