using System.Collections.Generic;
using EPiServer.Core;
using TestlessMVC.Common.Domain.BlockTypes;

namespace TestlessMVC.Common.Common.ViewModels
{
    public class StartViewPageModel
    {
        public XhtmlString Body { get; set; }
        public string Heading { get; set; }
        public NewsBlock News { get; set; }
        public ContentArea ContentAreaLeft { get; set; }
        public ContentArea ContentAreaRight { get; set; }
        public string Headline { get; set; }
        public string Author { get; set; }
    }
}