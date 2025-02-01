using System;

namespace LMS.MOD
{
    public class BookHistory
    {
        public int BookHistoryID { get; set; }
        public int BookBarcodeID { get; set; }
        public string BookBarcode { get; set; }
        public int CandidateID { get; set; }
        public DateTime? Date { get; set; }
        public string Status { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Unit { get; set; }
        public string ContactNumber { get; set; }
        public string BookName { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? ReturnedOn { get; set; }
    }
}
