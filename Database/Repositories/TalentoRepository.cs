using System;
using System.Linq;
using Database.Interfaces;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class TalentoRepository: Repository<Talento, Guid>, ITalentoRepository
    {
        
        public TalentoRepository(DbContext context)
            : base(context)
        {
        }

        public Talento GetByEmail(string email)
        {
            return DbSet.FirstOrDefault(c => c.Email == email);
        }
    }
}
