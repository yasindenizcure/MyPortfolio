using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FooterComponentPartial: ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var values = _context.SocialMedias.ToList();
            return View(values); 
        }
    }
}
