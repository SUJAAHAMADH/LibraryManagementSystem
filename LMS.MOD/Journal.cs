using System;

namespace LMS.MOD
{
    public class Journal
    {
        public int ID { get; set; } // Primary Key
        public string JournalName { get; set; } // Name of the journal
        public int Frequency { get; set; } // Number of journals in a year
        public decimal Price { get; set; } // Price of the journal
        public string InvoiceNo { get; set; } // Invoice number
        public DateTime InvoiceDate { get; set; } // Order date
        public string OrderNo { get; set; } // Order number
        public int LanguageID { get; set; } // Foreign key for the Language table

        public bool IsActive { get; set; } // Indicates if the journal is active (true/false)
    }
}
