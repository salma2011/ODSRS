using OmanDriveShcoolSystem.Model;
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

        public string feedback { get; set; }
        public bool isCompleted { get; set; }



        public void BookDrivingLesson(List<Student> students, List<Instructor> instructors, List<BookingLesson> bookingLessons)

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

            Console.Write("\nEnter Instructor ID: ");
            InstructorID = Console.ReadLine();

            while (!instructors.Any(ins => ins.InstructorID == InstructorID))
            {
                Console.WriteLine("\nInstructor ID not found. Please try again.\n");
                Console.Write("\nEnter Instructor ID: ");
                InstructorID = Console.ReadLine();
            }




            Console.Write("\nEnter Lesson Date (dd/mm/yyyy): ");
            date = Console.ReadLine();

            while (!Regex.IsMatch(date, @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$"))
            {

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


            BookingLesson newLesson = new BookingLesson()
            {
                studentId = studentId,
                InstructorID = InstructorID,
                date = date,
                time = time
            };
            bookingLessons.Add(newLesson);

            Console.WriteLine("\nLesson scheduled successfully\n");



        }

        public static void RecordLessonFeedback(List<BookingLesson> bookingLessons)
        {
            Console.WriteLine("Enter Student ID: ");
            string stuId = Console.ReadLine();

            Console.WriteLine("Enter Lesson Date (dd/mm/yyyy): ");
            string lessonDate = Console.ReadLine();

            var lesson = bookingLessons.FirstOrDefault(b => b.studentId == stuId && b.date == lessonDate);
            if (lesson != null)
            {
                Console.WriteLine("Enter Feedback: ");
                string fb = Console.ReadLine();
                lesson.feedback = fb;
                lesson.isCompleted = true;
                Console.WriteLine("Feedback saved and lesson marked as completed.\n");
            }
            else
            {
                Console.WriteLine("No matching lesson found.\n");
            }
        }


        public static void ViewStudentLessons(List<BookingLesson> bookingLessons, List<Student> students, List<Instructor> instructors)
        {
            Console.WriteLine("Enter Student ID: ");
            string stuId = Console.ReadLine();

            var student = students.FirstOrDefault(s => s.studentId == stuId);
            if (student == null)
            {
                Console.WriteLine(" Student not found.");
                return;
            }

            var lessons = bookingLessons.Where(b => b.studentId == stuId).ToList();

            if (!lessons.Any())
            {
                Console.WriteLine($"No lessons found for student {student.name}.");
                return;
            }

            Console.WriteLine($"\n Lesson history for {student.name}:");

            int count = 1;
            foreach (var lesson in lessons)
            {
                string instructorName = instructors.FirstOrDefault(i => i.InstructorID == lesson.InstructorID)?.Name ?? "Unknown";

                Console.WriteLine($"[{count++}] Date: {lesson.date} | Time: {lesson.time} | Instructor: {instructorName} | Feedback: {lesson.feedback ?? "No feedback"}");
            }
        }

        public static void ViewAllScheduledLessons(List<BookingLesson> bookingLessons, List<Student> students, List<Instructor> instructors)
        {
            int count = 1;
            foreach (var l in bookingLessons)
            {
                var student = students.FirstOrDefault(s => s.studentId == l.studentId);
                var instructor = instructors.FirstOrDefault(i => i.InstructorID == l.InstructorID);

                string studentName = student?.name ?? "no";
                string instructorName = instructor?.Name ?? "no";

                Console.WriteLine($"[{count++}] {l.studentId} | {studentName} | {l.InstructorID} | {instructorName} | {l.date} | {l.time}");
            }
        }

    }
}