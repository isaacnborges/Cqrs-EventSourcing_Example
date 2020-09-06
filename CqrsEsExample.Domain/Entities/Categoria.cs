using CqrsEsExample.Core.DomainObjects;
using System.Collections.Generic;

namespace CqrsEsExample.Domain.Entities
{
    public class Categoria : Entity
    {
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }
        public virtual IEnumerable<Produto> Produtos { get; private set; }
    }
}
