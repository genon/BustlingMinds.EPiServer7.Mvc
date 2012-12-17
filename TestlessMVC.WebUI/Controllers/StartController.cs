using System.Web.Mvc;
using EPiServer.Web.Mvc;
using TestlessMVC.Common.Common.ViewModels;
using TestlessMVC.Common.Domain.PageTypes;

namespace TestlessMVC.WebUI.Controllers
{
    public class StartController : PageController<StartPage>
    {
        [ContentOutputCache]
        public ActionResult Index(StartPage currentPage)
        { 
            var model = new StartViewPageModel
                            {
                                Heading = currentPage.Heading,
                                Headline = currentPage.Headline,
                                Body = currentPage.MainBody,
                                News = currentPage.NewsBlock,
                                ContentAreaLeft = currentPage.ContentAreaLeft,
                                ContentAreaRight = currentPage.ContentAreaRight,
                            };

            var editingHints = ViewData.GetEditHints<StartViewPageModel, StartPage>();
            editingHints.AddConnection(x => x.Body, x => x.MainBody);

            return View(model);
        } 
    }
}