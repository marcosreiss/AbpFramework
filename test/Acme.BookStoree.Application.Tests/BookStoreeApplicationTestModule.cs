using Volo.Abp.Modularity;

namespace Acme.BookStoree;

[DependsOn(
    typeof(BookStoreeApplicationModule),
    typeof(BookStoreeDomainTestModule)
    )]
public class BookStoreeApplicationTestModule : AbpModule
{

}
