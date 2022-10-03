using System;
using System.ComponentModel.DataAnnotations.Schema;
using DarpinosPizzaria.Models;

namespace DarpinosPizzaria.Models
{

    public class Cardapio
    {
        Random valor = new Random();
        public Cardapio () => Preco = valor.Next(25,90);

        [ForeignKey("Pizza")]
        public int PizzaId { get; set; }
        public virtual Pizza pizza { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente cliente { get; set; }
        public int Id { get; set; }
        public double Preco { get; set; }

    }
}