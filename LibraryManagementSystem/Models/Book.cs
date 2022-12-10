using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    abstract public class Book
    {
        [Key]
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public int NumberOfPages { get; set; }
        public string Language { get; set; }
        public IList<BookAuthor> Authors { get; set; }

    }
}
