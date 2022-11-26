using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Account
    {
        public int AccountID { get; set; }
        public string History { get; set; }
        public DateTime Opened { get; set; }
        public AccountState State { get; set; }
        public Library Library { get; set; }

        public IList<BookItem> ReservedBookItems { get; set; }
        public IList<BookItem> BorrowedBookItems { get; set; }
        public int PatronID { get; set; }
        public Patron Patron { get; set; }

    }
}
