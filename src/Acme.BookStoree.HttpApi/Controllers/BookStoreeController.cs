using Acme.BookStoree.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStoree.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookStoreeController : AbpControllerBase
{
    protected BookStoreeController()
    {
        LocalizationResource = typeof(BookStoreeResource);
    }
}
