global using Karma.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Karma.Models.Entities;
namespace Karma.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KarmaDbContext _context;

        public HomeController(ILogger<HomeController> logger, KarmaDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add() 
        {
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Sizes = _context.Sizes.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Sneakers model, List<int> colorsIds, List<int> sizesId)
        {
            var sneakers = new Sneakers()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                PreviousPrice = model.PreviousPrice,
                CategoryId = 1,
                isLiked = false,
                ProductCount = model.ProductCount,
            };
            _context.Sneakers.Add(sneakers);
            _context.SaveChanges();
            var sneakercolors = colorsIds.Select(c => new SneakersColor() { 
                ColorId = c,
                SneakersId = model.Id
            });
            var sneakersizes = sizesId.Select(s => new SneakersSize()
            {
                SizeId = s,
                SneakersId = model.Id,
            });
            _context.SneakersColors.AddRange(sneakercolors);
            _context.SneakersSizes.AddRange(sneakersizes);
            _context.SaveChanges();
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}