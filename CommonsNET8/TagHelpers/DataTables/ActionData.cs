using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CommonsNET8.TagHelpers.DataTables
{
    public class ActionData
    {
        public string ActionUrl { get; set; }
        public string ActionTitle { get; set; }
        public string CanExecuteProperty { get; set; }
        public string Classes { get; set; }
        public string Content { get; set; }
    }
}
