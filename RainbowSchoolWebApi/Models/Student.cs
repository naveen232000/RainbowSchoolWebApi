using System;
using System.Collections.Generic;

namespace RainbowSchoolWebApi.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }
        public int? Mark { get; set; }

        //public virtual Class? Class { get; set; }
        //public virtual Subject? Subject { get; set; }
    }
}
