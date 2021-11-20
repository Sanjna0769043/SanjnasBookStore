using Microsoft.AspNetCore.Mvc;
using SanjnasBooks.DataAccess.Repository.IRepository;
using SanjnasBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SanjnasBookStore.Areas.Admin.Controllers
{
    
        [Area("Admin")]
        public class CoverTypeController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;

            public CoverTypeController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public IActionResult Index()
            {
                return View();
            }
            
            #region API CALLS
            [HttpGet]
            public IActionResult GetAll()
            {
                var allObj = _unitOfWork.Category.GetAll();
                return Json(new { data = allObj });
            }
           /* [HttpDelete]
            public IActionResult Delete(int id)
            {
                var objFromDb = _unitOfWork.Category.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { sucess = false, message = "Error while deleting " });
                }
                _unitOfWork.Category.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { sucess = true, message = "Delete successful" });
            } */

            #endregion
        }

    }