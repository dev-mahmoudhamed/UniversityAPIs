﻿using System.ComponentModel.DataAnnotations;

namespace wepAPI.Entities
{
    public class Department
    {
        [Key]
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }    
        public string DepartmentHead { get; set; }
    }
}