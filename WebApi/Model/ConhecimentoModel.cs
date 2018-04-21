using System;
using Database.Models;

namespace WebApi.Model
{
    public class ConhecimentoModel
    {
        public ConhecimentoModel(Guid id, string titulo, Status status)
        {
            Id = id;
            Titulo = titulo;
            Status = status;
        }

        public Guid Id
        {
            get;
            private set;
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