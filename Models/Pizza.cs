using System.ComponentModel.DataAnnotations;
using DarpinosPizzaria.Validations;

namespace DarpinosPizzaria.Models
{
    public class Pizza
    {
        [Key()]
        public int Id { get; set; }
        
        [SaborCadastrado]
        public string Sabor { get; set; }

        [TamanhoCadastrado]
        public string Tamanho { get; set; }

    }
}