using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
