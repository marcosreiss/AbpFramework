using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStoree.Autors
{
    public class AutorDto : AuditedEntityDto<Guid>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
