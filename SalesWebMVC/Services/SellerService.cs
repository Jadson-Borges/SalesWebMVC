using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService
    { 
        //dependencia com proteção readonly
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
