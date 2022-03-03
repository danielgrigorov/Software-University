using Andreys.Models;
using Andreys.ViewModels.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Andreys.Services
{
    public interface IProdcutsService
    {
        int Add(ProductAddInputModel productAddInputModel);

        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void DeleteById(int id);


    }
}
