using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Acme.BookStoree.Books
{
    public class Autor : AggregateRoot<Guid>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
