using System.ComponentModel.DataAnnotations;
using System.Linq;
using DarpinosPizzaria.Models;

namespace DarpinosPizzaria.Validations
{
    public class TamanhoCadastrado : ValidationAttribute
    {   
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string tamanho = (string)value;
            DataContext context =
                (DataContext)validationContext.GetService(typeof(DataContext));

            Pizza pizza = context.Pizzas.FirstOrDefault
                (t => t.Tamanho.Equals(tamanho));
            if (pizza == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Este tamanho já está cadastrado!");
  
        }
    }
}