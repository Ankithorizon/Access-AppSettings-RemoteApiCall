using ApiClient.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ApiClient.Processes
{
    public class CallStudentApiService
    {
        public readonly Uri BaseUrl;
        public readonly string UserName = string.Empty;
        public readonly string Password = string.Empty;
        public readonly string appsettingsLocation = @"C:\Access-AppSettings\ApiClient\ApiClient";  
        public CallStudentApiService()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(Path.Combine(appsettingsLocation, "appsettings.json"));

            var root = builder.Build();

            BaseUrl = new Uri(root.GetSection("RemoteApiSettings").GetSection("BaseUrl").Value);
            UserName = root.GetSection("RemoteApiSettings").GetSection("UserName").Value;
            Password = root.GetSection("RemoteApiSettings").GetSection("Password").Value;
        }


        // if UserName, Password are successfully accessed from appsettings.json
        // file then call to remote api and return List<Student> 
        // otherwise return emplty List<Student>
        public List<Student> GetAllStudents_RemoteApiCall()
        {
            if (UserName == "canada" && Password == "winnipeg")
            {
                // call to Remote-Api and receives List<Student>

                List<Student> students = new List<Student>();
                students.Add(new Student()
                {
                    StudentId = 1,
                    StudentName = "Stduent-1"
                });
                students.Add(new Student()
                {
                    StudentId = 2,
                    StudentName = "Stduent-2"
                });
                students.Add(new Student()
                {
                    StudentId = 3,
                    StudentName = "Stduent-3"
                });
                students.Add(new Student()
                {
                    StudentId = 4,
                    StudentName = "Stduent-4"
                });
                students.Add(new Student()
                {
                    StudentId = 5,
                    StudentName = "Stduent-5"
                });
                return students;
            }
            else
                return new List<Student>();
        }
      
    }
}
