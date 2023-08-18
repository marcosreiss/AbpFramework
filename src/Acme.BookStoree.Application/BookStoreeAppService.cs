using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStoree.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStoree;

/* Inherit your application services from this class.
 */
public abstract class BookStoreeAppService : ApplicationService
{
    protected BookStoreeAppService()
    {
        LocalizationResource = typeof(BookStoreeResource);
    }
}
