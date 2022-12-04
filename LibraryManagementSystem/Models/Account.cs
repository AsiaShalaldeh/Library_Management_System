using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string History { get; set; }
        public DateTime Opened { get; set; }
        public AccountState State { get; set; }
        public int LibraryID { get; set; }
        public Library Library { get; set; }

        [InverseProperty("BorrowedAccount")]
        public IList<BookItem> BorrowedBook{ get; set; }
        public int? PatronID { get; set; }
        public Patron Patron { get; set; }

    }
}
