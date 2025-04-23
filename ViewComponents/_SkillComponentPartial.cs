using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial: ViewComponent
    {
        MyPortfolioContext _portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = _portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
