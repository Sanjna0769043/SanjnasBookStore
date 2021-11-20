using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjnasBooks.DataAccess.Repository
{
    class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverTypeRepository coverType)
    }
}
