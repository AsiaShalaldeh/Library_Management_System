using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryManagementSystem.Services.LibrarianService;

namespace LibraryManagementSystem.Services
{
    public interface IManageService
    {
        public void CreateLibrarian(string name, string password, string position, string address);
        public IList<int> GetLibrariansIDs();
        public IList<_Librarian> GetAllLibrarians();
    }
}
