using SanjnasBookStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjnasBooks.DataAccess.Repository.IRepository
{
    interface IProductRepository : IRepository<Product>
    {
        void Update(ProductRepository product)
    }
}
