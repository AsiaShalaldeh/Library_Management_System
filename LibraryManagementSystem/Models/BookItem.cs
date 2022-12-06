using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class BookItem : Book
    {
        public string Barcode { get; set; }
        public bool IsReferenceOnly { get; set; }
        public string RFID { get; set; }
        public int CatalogID { get; set; }
        public Catalog Catalog { get; set; }
        public int LibraryID { get; set; }
        public Library Library { get; set; }
        public int? AccountID { get; set; }
        public Account Account { get; set; }
        public int? LibrarianID { get; set; }
        public Librarian Librarian { get; set; }


    }
}
