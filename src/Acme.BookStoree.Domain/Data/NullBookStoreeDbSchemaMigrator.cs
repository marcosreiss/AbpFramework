using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoree.Data;

/* This is used if database provider does't define
 * IBookStoreeDbSchemaMigrator implementation.
 */
public class NullBookStoreeDbSchemaMigrator : IBookStoreeDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
