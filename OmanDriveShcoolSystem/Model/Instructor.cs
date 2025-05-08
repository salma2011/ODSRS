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
        public SpecializationTyp specialization { get; set; }

        public Instructor(string InstructorID, string Name, int PhoneNum, SpecializationTyp specialization)
        {
            this.InstructorID = InstructorID;
            this.Name = Name;
            this.PhoneNum = PhoneNum;
            this.specialization = specialization;
        }



        public static void addInstroctur(List<Instructor> instructors, ref int instruccounter)
        {

            string indexing = $"IN{instruccounter.ToString("D3")}";
            instruccounter++;

            Console.Write("Enter Instroctur Name: ");
            string Name = Console.ReadLine();


            Console.Write("Enter Phone Number: ");
            int PhoneNum = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter License Type (Light / Heavy / Motorcycle): ");
            string Instructorlicentype = Console.ReadLine();


            Instructor.SpecializationTyp specialization = (Instructor.SpecializationTyp)Enum.Parse(typeof(Instructor.SpecializationTyp), Instructorlicentype, true);


            instructors.Add(new Instructor(indexing, Name, PhoneNum, specialization));


            Console.WriteLine($"\nInstroctur registered with ID: {indexing}\n");



        }
    }
    }

