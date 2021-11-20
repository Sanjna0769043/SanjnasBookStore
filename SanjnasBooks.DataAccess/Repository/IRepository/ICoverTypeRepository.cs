using SanjnasBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjnasBooks.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<coverType>
    {
        void Update(ICoverTypeRepository coverType);
    }
}
