using System.Collections.Generic;

namespace LMS.MOD
{
    public class AvailableBook
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }
        public string Language { get; set; }
        public decimal? Price { get; set; }
        public string Isbn { get; set; }
        public string Description { get; set; }
        public int TotalQuantity { get; set; }
        public int AuthorID { get; set; }
        public string Author { get; set; }
        public int PublisherID { get; set; }
        public string Publisher { get; set; }
        public int UserID { get; set; }
        public int TotalReturnBook { get; set; }
        public int TotalIssueBook { get; set; }
        public int TotalAvailableBook { get; set; }
        public List<BookBarcode> BookBarcodes { get; set; }


    }
}
