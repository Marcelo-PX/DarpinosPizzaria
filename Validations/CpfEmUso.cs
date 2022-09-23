using System.ComponentModel.DataAnnotations;
using System.Linq;
using DarpinosPizzaria.Models;

namespace DarpinosPizzaria.Validations
{
    public class CpfEmUso : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cpf = (string)value;
            DataContext context =
                (DataContext)validationContext.GetService(typeof(DataContext));

            Cliente cliente = context.Clientes.FirstOrDefault
                (f => f.Cpf.Equals(cpf));
            if (cliente == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Este CPF já está em uso!");


        }
    }
}