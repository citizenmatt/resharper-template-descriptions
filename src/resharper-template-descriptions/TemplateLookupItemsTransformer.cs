using System.Linq;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems;
using JetBrains.ReSharper.Feature.Services.LiveTemplates.Util;
using JetBrains.ReSharper.Psi;

namespace CitizenMatt.ReSharper.LiveTemplates.Descriptions
{
    [Language(typeof(KnownLanguage))]
    public class TemplateLookupItemsTransformer : ItemsProviderOfSpecificContext<ISpecificCodeCompletionContext>
    {
        protected override void TransformItems(ISpecificCodeCompletionContext context, GroupedItemsCollector collector)
        {
            foreach (var templateLookupItem in collector.Items.OfType<TemplateLookupItem>().ToList())
            {
                if (!string.IsNullOrEmpty(templateLookupItem.Template.Description))
                {
                    collector.Add(new TemplateWithDescriptionLookupItem(templateLookupItem));
                    collector.Remove(templateLookupItem);
                }
            }
        }
    }
}