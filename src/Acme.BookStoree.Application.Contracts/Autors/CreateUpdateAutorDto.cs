using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations;
    
namespace Acme.BookStoree.Autors
{
    /*
     get a autor information from the user interface while creating 
     or updating the autor.

    It defines data annotation attributes (like [Required]) 
    to define validations for the properties. DTOs are automatically 
    validated by the ABP framework.

        RESPONDER A PERGUNTA: O QUE FAZ UMA CLASSE CreateUpdateEntityDto?
        REsposta: Responsável por pegar informações da interface de usuário para ser transferida pelo Dto
     */
    public class CreateUpdateAutorDto
    {
        [Required]
        [StringLength(255)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Endereço de email inválido.")]
        public string Email { get; set; }
    }
}   
