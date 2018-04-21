using System;

namespace Database.Models
{
    public class Conhecimento: EntityBase
    {
        public Conhecimento(Guid id, string titulo, Status status = Status.Ativo)
        {
            Id = id;
            Titulo = titulo;
            Status = status;
        }

        public string Titulo
        {
            get;
            private set;
        }

        public Status Status
        {
            get;
            private set;
        }
    }
}