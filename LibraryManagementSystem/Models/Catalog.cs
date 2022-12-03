using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Catalog : ISearch, IManage
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<BookItem> bookItems { get; set; }
    }
}
