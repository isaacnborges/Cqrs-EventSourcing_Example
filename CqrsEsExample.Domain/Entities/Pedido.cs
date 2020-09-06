using CqrsEsExample.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace CqrsEsExample.Domain.Entities
{
    public class Pedido : Entity
    {
        public int Codigo { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public decimal ValorTotalItens { get; set; }
        public decimal Desconto { get; private set; }
        public decimal ValorTotal { get; private set; }
        public IReadOnlyCollection<PedidoItem> OrdemServicoItens => _itens;
        private readonly List<PedidoItem> _itens;
    }
}
