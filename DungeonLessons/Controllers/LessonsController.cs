using System.Threading.Tasks;
using DungeonLessons.Data;
using DungeonLessons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DungeonLessons.Controllers
{
    public class LessonsController : Controller
    {
        private ApplicationDbContext db;
        public LessonsController(ApplicationDbContext context)
        {
            db = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await db.Lessons.ToListAsync());
        }
        
        public async Task<IActionResult> Show(int id)
        {
            return View(await db.Lessons.FindAsync(id));
        }
    }
}