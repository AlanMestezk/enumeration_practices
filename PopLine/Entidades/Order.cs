using System;

using PopLine.Entidades.Enums;


namespace PopLine.Entidades
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id do produto{Id} || Hora/Data da compra {Moment} || Status do pagamento: {Status}";
        }
    }
}
