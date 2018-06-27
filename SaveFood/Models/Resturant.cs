using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SaveFood.Models
{
    public class Resturant
    {
        public int Id { get; set; }

        [Required,MaxLength(80)]
        public string Name { get; set; }

        public CusineType CusineType { get; set; }
    }
}
