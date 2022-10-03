using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DarpinosPizzaria.Validations;

namespace DarpinosPizzaria.Models
{
    public class Pizza
    {
        [Key()]
        public int PizzaId { get; set; }
        
        [SaborCadastrado]
        public string Sabor { get; set; }
    
    }
}