using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartamentService (SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(ordem => ordem.Name).ToList();
        }
    }
}
