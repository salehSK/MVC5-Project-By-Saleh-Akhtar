using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MuhammadSalehAkhtar.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AdmissionDate { get; set; }
        public string FatherName { get; set; }
        public decimal CGpa { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

}