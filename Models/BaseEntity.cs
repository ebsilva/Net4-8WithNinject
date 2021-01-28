using System;

namespace Ebs.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Cadastro { get; set; } = DateTime.Now;
        public bool Ativo { get; set; }
    }
}