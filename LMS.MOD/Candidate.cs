using System;

namespace LMS.MOD
{
    public class Candidate
    {
        public int CandidateID { get; set; }
        public string Barcode { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string RoleID { get; set; }
        public string Rank { get; set; }
        public string Unit { get; set; }
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Battalion { get; set; }
        public string TOSDate { get; set; }
        public string SOSDate { get; set; }
        public string ThumbImpression { get; set; }
        public int UserID { get; set; }

        //New Fields Added
        public DateTime? DOB { get; set; }
        public string Stream { get; set; }
        public int? AcademicYear { get; set; }
        public string PermanentAddress { get; set; }
        public string PresentAddress { get; set; }
        public string Email { get; set; }
        public string ParentsContact { get; set; }
        public byte[] Photo { get; set; }
    }
}
