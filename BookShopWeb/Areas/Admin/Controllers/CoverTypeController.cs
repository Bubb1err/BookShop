using BookShop.DataAcess;
using BookShop.DataAcess.Repository.IRepository;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShopWeb.Areas.Admin.Controllers
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
            IEnumerable<CoverType> objCoverTypeList = _unitOfWork.CoverType.GetAll();
            return View(objCoverTypeList);
        }
        //get
        public IActionResult Create()
        {
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CoverType objCoverType)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Add(objCoverType);
                _unitOfWork.Save();
                TempData["success"] = "CoverType created successfully";
                return RedirectToAction("Index");
            }
            return View(objCoverType);

        }
        //get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var coverType = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            if (coverType == null)
                return NotFound();
            return View(coverType);
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CoverType obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.CoverType.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "CoverType updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);

        }
        //get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var covertype = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            if (covertype == null)
                return NotFound();
            return View(covertype);
        }
        //post
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var covertype = _unitOfWork.CoverType.GetFirstOrDefault(u => u.Id == id);
            if (covertype == null)
                return NotFound();
            _unitOfWork.CoverType.Remove(covertype);
            _unitOfWork.Save();
            TempData["success"] = "CoverType deleted successfully";
            return RedirectToAction("Index");
        }

    }
}
