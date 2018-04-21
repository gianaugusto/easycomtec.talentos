using System;
//using Flunt.Notifications;

namespace Database.Models
{
    public class EntityBase //: Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
