using Acme.BookStoree.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStoree;

[DependsOn(
    typeof(BookStoreeEntityFrameworkCoreTestModule)
    )]
public class BookStoreeDomainTestModule : AbpModule
{

}
