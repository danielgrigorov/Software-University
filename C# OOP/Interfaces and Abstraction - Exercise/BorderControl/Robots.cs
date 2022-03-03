using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robots : Imodelable, Idable
    {
        private string model;

        private string id;

        public Robots(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model 
        { 
            get => this.model; 
            set => this.model = value; 
        }

        public string Id 
        { 
            get => this.id; 
            set => this.id = value; 
        }

    }
}
