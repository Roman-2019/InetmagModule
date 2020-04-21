using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMVC.Models
{
    public class CategoryModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public object TovarModels { get; set; }
    }
}