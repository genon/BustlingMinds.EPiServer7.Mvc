using System.Web.Mvc;
using BustlingMinds.Episerver7.Mvc.Common.Common.ViewModels;
using EPiServer.Web.Mvc;
using TestlessMVC.Common.Domain.PageTypes;

namespace BustlingMinds.Episerver7.Mvc.WebUI.Controllers
{
    public class StandardController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            var standardModel = new StandardViewPageModel();
            standardModel.Heading = currentPage.Heading;
            standardModel.MainBody = currentPage.MainBody;

            return View(standardModel);
        }
    }
}