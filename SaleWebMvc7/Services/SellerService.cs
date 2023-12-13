using SalesWebMvc7.Data;
using SalesWebMvc7.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc7.Services
{
    public class SellerService
    {
        private readonly SalesWebMvc7Context _context;

        public SellerService(SalesWebMvc7Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Seller.Add(obj);
            _context.SaveChanges();
        }
    }
}
