using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
