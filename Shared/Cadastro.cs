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
        [EmailAddress]
        public string Email {get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [MinLength(6, ErrorMessage = "Senha precisa ter ao menos 6 caractéres")]
        public string Senha{get; set; }

        [Required(ErrorMessage = "Confirmar Senha é obrigatório")]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem")]
        public string ConfirmarSenha{get; set; }
        
        [Required]
        [Range(typeof(bool), "true","true", ErrorMessage = "Aceitar os termos é obrigatório")]
        public bool AceitarTermos {get; set; }
    }
}