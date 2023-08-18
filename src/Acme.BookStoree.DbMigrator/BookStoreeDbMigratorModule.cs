using Acme.BookStoree.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookStoree.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookStoreeEntityFrameworkCoreModule),
    typeof(BookStoreeApplicationContractsModule)
    )]
public class BookStoreeDbMigratorModule : AbpModule
{
}
