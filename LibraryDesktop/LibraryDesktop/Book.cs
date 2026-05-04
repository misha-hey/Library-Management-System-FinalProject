using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDesktop
{
    public class Book
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public string ImagePath { get; set; }
    }
}
