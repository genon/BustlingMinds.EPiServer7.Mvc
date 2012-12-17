using System.Web.Mvc;
using EPiServer.Web.Mvc;
using TestlessMVC.Common.Common.ViewModels;
using TestlessMVC.Common.Domain.PageTypes;

namespace TestlessMVC.WebUI.Controllers
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