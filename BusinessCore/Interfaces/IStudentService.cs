using ApiClient.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCore.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetAllStudents();
    }
}
