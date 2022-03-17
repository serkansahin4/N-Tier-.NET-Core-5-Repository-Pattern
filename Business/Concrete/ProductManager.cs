using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _pDal;
        public ProductManager(IProductDal pDal)
        {
            _pDal = pDal;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await _pDal.GetAll();
        }
    }
}
