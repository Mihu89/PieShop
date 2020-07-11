using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieShop.Data;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    [Authorize]
    public class PieController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPieRepository _pieRepository;

        public PieController(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }
        public IActionResult List()
        {
            // ViewBag.CurrentCategory = "Cheese cakes";
            PieListViewModel pieVM = new PieListViewModel();
            pieVM.Pies = _pieRepository.AllPies;
            pieVM.CurentCategory = "Cheese cakes";

            return View(pieVM);
        }
    }
}