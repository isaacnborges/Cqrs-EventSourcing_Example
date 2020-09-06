using CqrsEsExample.Core.DomainObjects;
using System;
using System.Collections.Generic;

namespace CqrsEsExample.Domain.Entities
{
    public class Produto : Entity
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public Guid CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; }
        public virtual IEnumerable<PedidoItem> PedidoItens { get; private set; }
    }
}
