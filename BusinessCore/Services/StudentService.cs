﻿using System;
using System.Collections.Generic;
using System.Text;
using ApiClient.Models;
using ApiClient.Processes;
using BusinessCore.Interfaces;

namespace BusinessCore.Services
{
    public class StudentService : IStudentService
    {

        public readonly CallStudentApiService apiClient;

        public StudentService()
        {
            apiClient = new CallStudentApiService();
        }

        // this will call ApiClient project
        // and ApiClient project will call remote-api
        public List<Student> GetAllStudents()
        {
            return apiClient.GetAllStudents_RemoteApiCall();
        }
    }
}
