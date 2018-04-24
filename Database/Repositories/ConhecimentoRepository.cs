using System;
using System.Linq;
using Database.Interfaces;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class ConhecimentoRepository: Repository<Conhecimento, Guid>, IConhecimentoRepository
    {
        
        public ConhecimentoRepository(DbContext context)
            : base(context)
        {
        }


    }
}
