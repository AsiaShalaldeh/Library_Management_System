using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Patron : ISearchService
    {
        public int PatronID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public int? AccountID { get; set; }

        public Account Account { get; set; }


    }
}
