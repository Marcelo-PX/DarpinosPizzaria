using System;

namespace DarpinosPizzaria.Models
{
    public class Cliente
    {
        public Cliente () => CriadoEm = DateTime.Now; 
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}