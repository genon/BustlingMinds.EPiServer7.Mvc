using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace TestlessMVC.Common.Domain.PageTypes
{
    [ContentType(DisplayName = "[Testless] Standard page",
    GUID = "05a53fc3-58b8-4e27-b7b6-9f1e91eb71ba",
    Description = "Standard page")]
    public class StandardPage : BasePageData
    {
        [Editable(true)]
        [Display(Name = "Main body",
            Description = "Main content of the page",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }
    }
}