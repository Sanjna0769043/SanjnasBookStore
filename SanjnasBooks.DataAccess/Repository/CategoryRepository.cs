﻿using SanjnasBooks.DataAccess.Repository.IRepository;
using SanjnasBooks.Models;
using SanjnasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanjnasBooks.DataAccess.Repository
{ 
    public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use.NET LINQ to retrieve the first or default category objects,
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) // save changer if not null
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
