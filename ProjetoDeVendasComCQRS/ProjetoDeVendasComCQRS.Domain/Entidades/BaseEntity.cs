using System;

namespace ProjetoDeVendasComCQRS.Domain.Entidades
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
