using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Util;
using JetBrains.UI.RichText;

namespace CitizenMatt.ReSharper.LiveTemplates.Descriptions
{
    public class TemplateWithDescriptionLookupItem : WrappedLookupItem, IDescriptionProvidingLookupItem
    {
        private readonly TemplateLookupItem templateLookupItem;

        public TemplateWithDescriptionLookupItem(TemplateLookupItem templateLookupItem)
            : base(templateLookupItem)
        {
            this.templateLookupItem = templateLookupItem;
        }

        public RichTextBlock GetDescription()
        {
            return new RichTextBlock(templateLookupItem.Template.Description);
        }
    }
}