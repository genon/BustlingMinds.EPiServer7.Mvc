using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using TestlessMVC.Common.Domain.BlockTypes;

namespace TestlessMVC.Common.Domain.PageTypes
{
    [ContentType(DisplayName = "[Testless] Start page",
        GUID = "0671b60b-d669-47b4-99f4-4f0838b7e136",
        Description = "Start page")]
    public class StartPage : BasePageData
    {
        [Editable(true)]
        [Display(Name = "Headline",
            Description = "Headline for body",
            GroupName = SystemTabNames.Content,
            Order = 9)]
        public virtual string Headline { get; set; }
        
        [Editable(true)]
        [Display(Name = "Main body",
            Description = "Main content of the page",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

        public virtual NewsBlock NewsBlock { get; set; }

        [Display(Name = "Content area",
            Description = "A content for adding any shared block",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual ContentArea ContentAreaLeft { get; set; }

        [Display(Name = "Content area right",
            Description = "A content for adding any shared block",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual ContentArea ContentAreaRight { get; set; }
        
    }
}