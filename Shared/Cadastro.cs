using System;
using System.ComponentModel.DataAnnotations;

namespace Desafio_Asdrubal.Shared
{
    public class Cadastro
    {
        [Required(ErrorMessage = "Tipo de sexo é obrigatório")]
        public string Sr_Sra { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = "Data é obrigatório")]
        public DateTime Data_Nascimento { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        public string Email {get; set; }
    }
}