using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaveFood.Data;
using SaveFood.Models;

namespace SaveFood.Services
{
    public class SqlResturantData : IResturantData
    {
        public SqlResturantData(SaveFoodDataContext context)
        {
            Context = context;
        }

        public SaveFoodDataContext Context { get; }

        public Resturant GetResturant(int id)
        {
           return this.Context.Resturants.FirstOrDefault(p => p.Id == id);
        }

        public List<Resturant> GetResturants()
        {
            return this.Context.Resturants.OrderBy(p => p.Name)?.ToList();
        }

        public void SaveResturant(Resturant resturant)
        {
            this.Context.Resturants.Add(resturant);
            this.Context.SaveChanges();
        }
    }
}
