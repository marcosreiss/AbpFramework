using System.Threading.Tasks;

namespace Acme.BookStoree.Data;

public interface IBookStoreeDbSchemaMigrator
{
    Task MigrateAsync();
}
