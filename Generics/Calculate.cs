using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Calculate<T> where T : IAnimal
    {

        public decimal GetWeight(IEnumerable<T> animals)
        {
          return  animals.Sum(x => x.Height);
        }

        public decimal GetHeight(IEnumerable<T> animals)
        {
            return animals.Sum(x => x.Weight);
        }

        public IEnumerable<T> FurAnimals(IEnumerable<T> animals)
        {
           return animals.Where(x => x.HasFur);
        }
    }
}
