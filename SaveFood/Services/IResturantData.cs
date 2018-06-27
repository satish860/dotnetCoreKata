using SaveFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveFood.Services
{
    public interface IResturantData
    {
        List<Resturant> GetResturants();
    }
}
