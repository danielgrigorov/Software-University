using Easter.Models.Bunnies.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Repositories.Contracts
{
    public class BunnyRepository : IRepository<IBunny>
    {
        private readonly ICollection<IBunny> models;
        public BunnyRepository()
        {
            this.models = new List<IBunny>();
        }

        public IReadOnlyCollection<IBunny> Models => (IReadOnlyCollection<IBunny>)this.models;

        public void Add(IBunny model)
        {
            this.models.Add(model);
        }

        public IBunny FindByName(string name)
        {
            return this.models.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IBunny model)
        {
            return this.models.Remove(model);
        }
    }
}
