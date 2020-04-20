using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopAPI.Models
{
    public class CategoryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TovarApiModel> Tovar { get; set; }
    }
}