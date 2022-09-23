using System;
namespace DarpinosPizzaria.Interfaces
{
    enum Sabores
    {
        frango,
        calabresa,
        doisAmores
    }
    interface IPizza
    {
        public Array sabores { get; set; }
        public double Preco { get; set; }
        public int numeroDeSabores { get; set; }

    }
}
