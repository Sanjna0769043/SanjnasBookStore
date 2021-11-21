using Microsoft.AspNetCore.Mvc;
using SanjnasBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanjnasBookStore.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        /*
        public IActionResult Upsert(int? id)    //action method for Upsert
        {
            Product product = new Product();
            if (id == null)
            {
                // this is for create
                return View(product);
            }

            //this for the edit
            product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (product == null)
            {
                return NotFound();
            }
            return View();
        } 

        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Product product)
        {
            if (ModelState.IsValid)     // checks all validations in the model
            {
                if (product.Id == 0)
                {
                    _unitOfWork.Product.Add(product);

                }
                else
                {
                    _unitOfWork.Product.Update(product);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index)); // to see all the categories


            }
            return View(product);
        }
        */

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Product.GetAll();
            return Json(new { data = allObj });
        }
        /*
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { sucess = false, message = "Error while deleting " });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { sucess = true, message = "Delete successful" });
        } */
        
        #endregion
    }

}