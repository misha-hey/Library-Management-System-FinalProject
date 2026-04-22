namespace LibraryAPI.Models
{
    public class ReturnBook
    {
        public int ReturnBookId { get; set; }
        public int BorrowId { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal FineAmount { get; set; }
    }
}