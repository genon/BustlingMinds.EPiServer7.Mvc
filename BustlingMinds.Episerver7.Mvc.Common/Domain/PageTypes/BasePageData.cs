using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;

namespace TestlessMVC.Common.Domain.PageTypes
{

    public class BasePageData : PageData
    {
        [Editable(true)]
        [Display(Name = "Heading",
            Description = "Heading of the page",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Heading { get; set; }
    }
}