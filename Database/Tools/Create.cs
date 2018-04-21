using System;
namespace Database.Tools
{
    public class Create
    {
        private readonly Context context;

        public Create(Context context)
        {
            this.context = context;
        }

        public bool DatabaseExists() =>
            context.Database.EnsureCreated();


    }
}
