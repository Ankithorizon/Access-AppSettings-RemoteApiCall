using System;
using System.Collections.Generic;
using ApiClient.Models;
using BusinessCore.Interfaces;
using BusinessCore.Services;

namespace StartupBusinessCore
{
    class Program
    {
        private readonly IStudentService studentService;
        private List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Program p = new Program();

            // starting up business-core project
            p.Calling_BusinessCore_StudentService();
        }

        public Program()
        {
            studentService = new StudentService();
        }

        // starting up business-core project
        public void Calling_BusinessCore_StudentService()
        {
            students = studentService.GetAllStudents();
            
            
            // for checking that ApiClient has called remote api
            // and here in console application checkes if data receives
            // from ApiClient-->remote api
            DisplayStudents();
        }

        public void DisplayStudents()
        {
            foreach(var student in students)
            {
                Console.WriteLine(student.StudentId + " ---> " + student.StudentName );                
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
