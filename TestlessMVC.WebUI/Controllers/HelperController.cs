using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using TestlessMVC.Common.Domain.PageTypes;

namespace TestlessMVC.WebUI.Controllers
{
    public class HelperController : Controller
    {
        private readonly IContentRepository _contentRepository;

        public HelperController()
        {
            _contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
        }

        public ActionResult MainMenu()
        {
            var parent = _contentRepository.Get<StartPage>(ContentReference.StartPage);
            var children = _contentRepository.GetChildren<PageData>(ContentReference.StartPage);

            var menuLinks = new List<MenuLink> { new MenuLink { Name = parent.PageName, Url = parent.LinkURL}};

            FilterForVisitor.Filter(children);

            if (children != null)
            {
                menuLinks.AddRange(children.Select(child => new MenuLink {Name = child.PageName, Url = child.LinkURL}));
            }

            return View(menuLinks);
        }

    }
}
