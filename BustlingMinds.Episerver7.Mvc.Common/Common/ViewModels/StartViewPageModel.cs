using EPiServer.Core;

namespace BustlingMinds.Episerver7.Mvc.Common.Common.ViewModels
{
    public class StartViewPageModel
    {
        public XhtmlString Body { get; set; }
        public string Heading { get; set; }
        public ContentArea ContentAreaLeft { get; set; }
        public ContentArea ContentAreaRight { get; set; }
        public string Headline { get; set; }
        public string Author { get; set; }
    }
}