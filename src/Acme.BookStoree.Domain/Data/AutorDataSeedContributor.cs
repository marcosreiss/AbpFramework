using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Acme.BookStoree.Autors;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore;

public class AutorDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Autor, Guid> _autorRepository;

    public AutorDataSeederContributor(IRepository<Autor, Guid> autorRepository)
    {
        _autorRepository = autorRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _autorRepository.GetCountAsync() <= 0)
        {
            await _autorRepository.InsertAsync(
                new Autor
                {
                    Nome = "Antoine de Saint-Exupéry",
                    Email = "Antoine@gmail.com"
                },
                autoSave: true
            );

            await _autorRepository.InsertAsync(
                new Autor
                {
                    Nome = "Machado de Asis",
                    Email = "Machado98@gmail.com"
                },
                autoSave: true
            );
        }
    }
}
