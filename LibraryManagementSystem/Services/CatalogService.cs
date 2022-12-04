using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class CatalogService
    {
        private LibraryContext _context;
        public CatalogService()
        {
            _context = new LibraryContext();
        }
        public void CreateCatalog(string catalog)
        {
            Catalog new_catalog = new Catalog();
            new_catalog.Name = catalog;
            _context.Catalog.Add(new_catalog);
            _context.SaveChanges();
        }
        public IList<int> GetCatalogsIDs()
        {
            IList<int> ids = new List<int>();
            try
            {
                var list = _context.Catalog.Select(c => c.ID);
                foreach (var id in list)
                {
                    ids.Add(id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ids;
        }
    }
}
