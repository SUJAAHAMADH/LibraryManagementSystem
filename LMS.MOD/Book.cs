using System;
using System.Collections.Generic;

namespace LMS.MOD
{
    public class Book
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }
        public string Language { get; set; }
        public int LanguageID { get; set; }
        public int CategoryID { get; set; }
        public string Category { get; set; }
        public string Funds { get; set; }
        public bool IsRestricted { get; set; }
        public decimal? Price { get; set; }
        public string Isbn { get; set; }
        public string Description { get; set; }
        public int TotalQuantity { get; set; }
        public int AuthorID { get; set; }
        public string Author { get; set; }
        public int PublisherID { get; set; }
        public string Publisher { get; set; }
        public int UserID { get; set; }
        public List<BookBarcode> BookBarcodes { get; set; }

        public string VolumeNo { get; set; }
        public string Vendor { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public string OfficeOrder { get; set; }
        public DateTime? OfficeOrderDate { get; set; }
        public decimal? Discount { get; set; }
        public string RackNo { get; set; }

    }
}
