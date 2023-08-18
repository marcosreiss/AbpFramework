using Acme.BookStoree.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Acme.BookStoree.Blazor;

public abstract class BookStoreeComponentBase : AbpComponentBase
{
    protected BookStoreeComponentBase()
    {
        LocalizationResource = typeof(BookStoreeResource);
    }
}
