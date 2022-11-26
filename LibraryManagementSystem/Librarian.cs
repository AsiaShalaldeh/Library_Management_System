﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Librarian : ISearch, IManage
    {
        public int LibrarianID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
