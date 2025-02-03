using System;
namespace LMS.MOD
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string NameOfStudent { get; set; }
        public DateTime DOB { get; set; }
        public string Stream { get; set; }
        public int AcademicYear { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string Email { get; set; }
        public string ParentsContact { get; set; }
        public string StudentContact { get; set; }
        public byte[] Photo { get; set; }
    }
}
