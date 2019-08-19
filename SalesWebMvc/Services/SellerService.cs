using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            this._context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); //a cessa a fonte de dados relacionada a tabela de vendedores e transforma-a em lisat
        }

        public void Insert(Seller seller)
        {
            _context.Seller.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(x => x.Id == id);
        }

        public void Remove(int id)
        {
            _context.Seller.Remove(this.FindById(id));//removi do dbSet, falta saveChanges pra alterar no banco
            _context.SaveChanges();
        }
    }
}
