using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Q4
{
    class SchoolDemo
    {
        private int _rollNumber;
        private string _studentName;
        private byte _age;
        private char _gender;
        private DateTime _dateOfBirth;
        private string _address;
        private float _percentage;

        public SchoolDemo()
        {
            RollNumber = 1;
            StudentName = "Akhil";
            Age = 21;
            Gender = 'M';
            DateOfBirth = new DateTime(1998 , 05 , 06);
            //string date = DateOfBirth.ToString("dd/MM/yyyy");
            Address = "Capgemini, Mumbai";
            Percentage = 81;
        }

        public int RollNumber { get => _rollNumber; set => _rollNumber = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public byte Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string Address { get => _address; set => _address = value; }
        public float Percentage { get => _percentage; set => _percentage = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDemo sd = new SchoolDemo();
            Console.WriteLine("Name: " + sd.StudentName);
            Console.WriteLine("Gender: " + sd.Gender);
            Console.WriteLine("Roll Number: " + sd.RollNumber);
            Console.WriteLine("Date of Birth: " + sd.DateOfBirth.ToShortDateString());
            Console.WriteLine("Age: " + sd.Age);
            Console.WriteLine("Address: " + sd.Address);
            Console.WriteLine("Percentage: " + sd.Percentage);
        }
    }
}
