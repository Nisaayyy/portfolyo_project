using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPorfolioContext portfolioContext = new MyPorfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle =portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.abouDetail=portfolioContext.Abouts.Select(x=>x.Detail).FirstOrDefault();


            return View();
        }
    }
}
