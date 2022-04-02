﻿using System.ComponentModel.DataAnnotations;

namespace wepAPI.Entities
{
    public class Course
    {
        [Key]
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseInstractor { get; set; }
    }
}