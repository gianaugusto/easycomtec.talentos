using System;
using Database.Models;

namespace Database.Interfaces
{
    public interface ITalentoRepository : IRepository<Talento, Guid>
    {
        Talento GetByEmail(string email);
    }
}
