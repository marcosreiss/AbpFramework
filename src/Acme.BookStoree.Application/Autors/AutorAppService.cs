using Acme.BookStoree.Autors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStoree.Autors
{
    public class AutorAppService : CrudAppService<
        Autor,
        AutorDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateAutorDto>,
        IAutorAppService
    {
        public AutorAppService(IRepository<Autor, Guid> repository) : base(repository) 
        {
        
        }

    }
}
