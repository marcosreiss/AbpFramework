using Acme.BookStore.Books;
using Acme.BookStoree.Autors;
using AutoMapper;

namespace Acme.BookStoree;

public class BookStoreeApplicationAutoMapperProfile : Profile
{
    public BookStoreeApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        // mapeamento da entidade Autor

        CreateMap<Autor, AutorDto>();
        CreateMap<Autor, CreateUpdateAutorDto>();

    }
}
