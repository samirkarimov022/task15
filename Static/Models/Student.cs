using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.Models
{
    internal class Student
    {
        
        string _name;
        string _surname;
        byte _age;
        static int _salary;

        static Student() 
        {
          _salary = 1000;
        }

        public Student(string name, string surname,byte age)
        {
           _name=name;
            _surname=surname;
            _age = age;    
        }
        public void Getinfo() 
        {
            Console.WriteLine($"Ad: {_name}\nSoyad: {_surname}\nYas: {_age}\nmaas: {_salary}");
        }
        public static void Primary(int primary)
        {

            Console.WriteLine(_salary + primary);
        }
    }
}
