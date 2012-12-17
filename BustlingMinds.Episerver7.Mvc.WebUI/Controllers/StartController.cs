using System.Web.Mvc;
using BustlingMinds.Episerver7.Mvc.Common.Common.ViewModels;
using BustlingMinds.Episerver7.Mvc.Common.Domain.PageTypes;
using EPiServer.Web.Mvc;

namespace BustlingMinds.Episerver7.Mvc.WebUI.Controllers
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
                                ContentAreaLeft = currentPage.ContentAreaLeft,
                                ContentAreaRight = currentPage.ContentAreaRight,
                            };

            var editingHints = ViewData.GetEditHints<StartViewPageModel, StartPage>();
            editingHints.AddConnection(x => x.Body, x => x.MainBody);

            return View(model);
        } 
    }
}