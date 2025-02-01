namespace LMS.MOD
{
    public class BookBarcode
    {
        public int BookBarcodeID { get; set; }
        public int BookID { get; set; }
        public string Barcode { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int CategoryID { get; set; }
        public string Category { get; set; }
        public string Funds { get; set; }
        public bool IsRestricted { get; set; }

    }
}