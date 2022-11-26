using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class BookItem : Book
    {
        public string Barcode { get; set; }
        public bool IsReferenceOnly { get; set; }
        public string RFID { get; set; }
        public Catalog Catalog { get; set; }
        public Library Library { get; set; }
        public Account Account { get; set; }


    }
}
