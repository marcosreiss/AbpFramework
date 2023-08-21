using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStoree.Autors
{
    public interface IAutorAppService : ICrudAppService< //define os serviçoes de  CRUD
        AutorDto, // usado para mostrar os autores 
        Guid, // chave primária da entidade Autor 
        PagedAndSortedResultRequestDto, //usado para pagin/sorting  
        CreateUpdateAutorDto> // usado para criar/atualizar autores

    {

    }
}
