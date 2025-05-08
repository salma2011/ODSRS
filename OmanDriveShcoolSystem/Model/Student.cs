using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanDriveShcoolSystem.Model
{
    public class Student
    {
        public enum Licensetype
        {
            Light,
            Heavy,
            Motorcycle
        }


        public string studentId { get; set; }
        public string name { get; set; }
        public int PhoneNo { get; set; }
        public Licensetype license { get; set; }

        public Student(string studentId, string name, int PhoneNo, Licensetype license)
        {
            this.studentId = studentId;
            this.name = name;
            this.PhoneNo = PhoneNo;
            this.license = license;
        }

        public static void addStudent(List<Student> students, ref int studentCounter)
        {

                string indexing = $"ST{studentCounter.ToString("D3")}";
                studentCounter++; 

                Console.Write("Enter Student Name: ");
                string stuName = Console.ReadLine();


                Console.Write("Enter Phone Number: ");
                int stuPhone = Convert.ToInt32(Console.ReadLine());


                Console.Write("Enter License Type (Light / Heavy / Motorcycle): ");
                string stuLice = Console.ReadLine();


                Student.Licensetype license = (Student.Licensetype)Enum.Parse(typeof(Student.Licensetype), stuLice, true);


                students.Add(new Student(indexing, stuName, stuPhone, license));


                Console.WriteLine($"\nStudent registered with ID: {indexing}\n");  

        }


    }
}
