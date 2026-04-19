namespace LibraryAPI.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } = "";
    }
}