using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Acme.BookStoree.Autors
{
    /*
     get a autor information from the user interface while creating 
     or updating the autor.

    It defines data annotation attributes (like [Required]) 
    to define validations for the properties. DTOs are automatically 
    validated by the ABP framework.

        RESPONDER A PERGUNTA: O QUE FAZ UMA CLASSE CreateUpdateEntityDto
     */
    public class CreateUpdateAutorDto
    {
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
