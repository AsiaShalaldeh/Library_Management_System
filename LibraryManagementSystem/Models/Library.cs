using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Library
    {
        public int LibraryID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public int CatalogID { get; set; }
        //public Catalog Catalog { get; set; }
        public IList<BookItem> bookItems { get; set; }
        public IList<Account> Accounts { get; set; }
        public IList<Catalog> Catalogs { get; set; }
    }
}
