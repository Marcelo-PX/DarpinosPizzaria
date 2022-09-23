using System;
using System.ComponentModel.DataAnnotations;
using DarpinosPizzaria.Validations;

namespace DarpinosPizzaria.Models
{
    public class Cliente
    {
        public int Id { get; set; }


        [Required(
            ErrorMessage = "O campo nome é obrigatório!"
        )]
        public string Nome { get; set; }


        [StringLength(
          11,
          MinimumLength = 11,
          ErrorMessage = "Numero de CPF deve conter 11 digitos!"
        )]
        [CpfEmUso]
        public string Cpf { get; set; }


        [Required(
           ErrorMessage = "O campo Telefone é obrigatório!"
        )]
        [StringLength(
           11,
           MinimumLength = 11,
           ErrorMessage = "Numero de telefone invalido!"
        )]

        public string Telefone { get; set; }


        [Required(
            ErrorMessage = "O campo endereço é obrigatório"
        )]
        public string Endereco { get; set; }


    }
}