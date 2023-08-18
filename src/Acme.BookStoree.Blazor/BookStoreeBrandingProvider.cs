using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.BookStoree.Blazor;

[Dependency(ReplaceServices = true)]
public class BookStoreeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookStoree";
}
