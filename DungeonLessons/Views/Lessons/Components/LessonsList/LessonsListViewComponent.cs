using System.Collections.Generic;
using System.Threading.Tasks;
using DungeonLessons.Data;
using DungeonLessons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DungeonLessons.Views.Lessons.Components.LessonsList
{
    public class LessonsListViewComponent : ViewComponent
    {
        private readonly DbSet<Lesson> _lessons;
        public LessonsListViewComponent(ApplicationDbContext context)
        {
            _lessons = context.Lessons;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Lesson> list = await _lessons.ToListAsync();
            return View("LessonsList", list);
        }
    }
}