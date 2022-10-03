using System.ComponentModel.DataAnnotations;
using System.Linq;
using DarpinosPizzaria.Models;

namespace DarpinosPizzaria.Validations
{
    public class SaborCadastrado : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string sabor = (string)value;
            DataContext context =
                (DataContext)validationContext.GetService(typeof(DataContext));

            Pizza pizza = context.Pizzas.FirstOrDefault
                (s => s.Sabor.Equals(sabor));
            if (pizza == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Este Sabor já está cadastrado!");

        }
    }
}