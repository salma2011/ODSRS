using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OmanDriveShcoolSystem.Model
{
    internal class Instructor
    {
        public enum SpecializationTyp { Light, Heavy, Motocycle }


        public string InstructorID { get; set; }

        public string Name { get; set; }
        public int PhoneNum { get; set; }
        public string specialization { get; set; }

        public Instructor(string InstructorID, string Name, int PhoneNum, string specializatin)
        {
            this.InstructorID = InstructorID;
            this.Name = Name;
            this.PhoneNum = PhoneNum;
            this.specialization = specializatin;
        }



        public static void addInstroctur(List<Instructor> instructors, ref int instruccounter)
        {
            Console.WriteLine("Enter number of Instructor : ");
            int numberOfInstructor = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfInstructor; i++)
            {
                string indexing = $"Ins{instruccounter++}";
                Console.WriteLine("Enter Instructor Name: ");
                string InstName = Console.ReadLine();
                Console.WriteLine("Enter Phone Number: ");
                int InstPhone = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Specialization Type (Light / Heavy / Motorcycle): ");
                string InstSpec = Console.ReadLine();
                Instructor.SpecializationTyp Insp = (Instructor.SpecializationTyp)Enum.Parse(typeof(Instructor.SpecializationTyp), InstSpec, true);
                instructors.Add(new Instructor(indexing, InstName, InstPhone, InstSpec));
                Console.WriteLine("Done Added Instructor ");
            }
            foreach (var instructor in instructors)
            {
                Console.WriteLine($"ID: {instructor.InstructorID}, Name: {instructor.Name}, Phone: {instructor.PhoneNum}, Specialization: {instructor.specialization}");






            }
        }
    }
}