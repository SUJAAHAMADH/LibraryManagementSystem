using System;

namespace LMS.MOD
{
    public class IssueBook
    {
        public int IssueBookID { get; set; }
        public int BookBarcodeID { get; set; }
        public string BookBarcode { get; set; }
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int CandidateID { get; set; }
        public string RollId { get; set; }
        public DateTime? IssuedOn { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? ReturnedOn { get; set; }
        public DateTime? RenewalOn { get; set; }
        public int NoOfTimeRenewal { get; set; }
        public string Remark { get; set; }
        public int UserID { get; set; }
        //public Book Book { get; set; }
        public string CandidateName { get; set; }
        public string CandidateNames { get; set; }
    }
}
