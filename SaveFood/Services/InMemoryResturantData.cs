using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaveFood.Models;

namespace SaveFood.Services
{
    public class InMemoryResturantData : IResturantData
    {
        public List<Resturant> resturants;
        public InMemoryResturantData()
        {
            this.resturants= new List<Resturant>
            {
                new Resturant{Id=1,Name="Pizza Hut"},
                new Resturant{Id=2,Name="Baskin Robins"},
                new Resturant{Id=3,Name="Sansar"}
            };
        }
        public Resturant GetResturant(int id)
        {
           return this.resturants.FirstOrDefault(p => p.Id==id);
        }

        public List<Resturant> GetResturants()
        {
            return this.resturants;
        }
    }
}
