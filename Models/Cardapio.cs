using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DarpinosPizzaria.Models;

namespace DarpinosPizzaria.Models
{

    public class Cardapio
    { 
        [ForeignKey("Pizza")]
        public int PizzaId { get; set; }
        public virtual Pizza Pizza { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public int CardapioId { get; set; }
        public string Tamanho { get; set; }
        public double Preco { get; set; }

    }
}