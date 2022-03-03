using Easter.Models.Eggs.Contracts;
using Easter.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Easter.Repositories
{
    public class EggRepository : IRepository<IEgg> 
    {
        private readonly ICollection<IEgg> models;
        public EggRepository()
        {
            this.models = new List<IEgg>();
        }

        public IReadOnlyCollection<IEgg> Models => (IReadOnlyCollection<IEgg>)this.models;

        public void Add(IEgg model)
        {
            this.models.Add(model);
        }

        public IEgg FindByName(string name)
        {
            var bunnyToFind = this.models.FirstOrDefault(x => x.Name == name);

            if (bunnyToFind == null)
            {
                return null;
            }
            else
            {
                return bunnyToFind;
            }
        }

        public bool Remove(IEgg model)
        {
            return this.models.Remove(model);
        }
    }
}
