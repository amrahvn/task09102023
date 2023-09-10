using LastBackProje.DataAccesLAyer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LastBackProje.ViewComponents
{
    public class tab_contentViewComponent
    {
        private readonly AppDbContext _context;

        public tab_contentViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var tab=await _context.Products
                .Where

            //var sliders = await _context.Sliders
            //   .Where(s => s.IsDeleted == false)
            //   .ToListAsync();

            //return View(sliders);
        }
    }
}
