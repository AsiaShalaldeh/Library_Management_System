using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    // : ISearchService, IManageService
    public class Catalog 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public int LibraryID { get; set; }
        public Library Library { get; set; }
        public IList<BookItem> bookItems { get; set; }
    }
}
