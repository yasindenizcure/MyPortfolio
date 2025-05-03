using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SocialMediaComponentPartial: ViewComponent
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _portfolioContext.SocialMedias.ToList();
            return View(values);
        }
    }
    
}

