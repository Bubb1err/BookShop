using BookShop.DataAcess.Repository.IRepository;
using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.DataAcess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
            :base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            var objFromdb = _db.Products.FirstOrDefault(u=>u.Id==obj.Id);
            if(objFromdb!=null)
            {
                objFromdb.Title = obj.Title;
                objFromdb.ISBN =obj.ISBN;
                objFromdb.Price = obj.Price;
                objFromdb.Price50 = obj.Price50;
                objFromdb.ListPrice = obj.ListPrice;
                objFromdb.Price100 = obj.Price100;
                objFromdb.Describtion = obj.Describtion;
                objFromdb.CategoryId = obj.CategoryId;
                objFromdb.Author = obj.Author;
                objFromdb.CoverTypeId = obj.CoverTypeId;
                if(obj.ImageUrl != null)
                    objFromdb.ImageUrl = obj.ImageUrl;
            }
        }
    }
}
