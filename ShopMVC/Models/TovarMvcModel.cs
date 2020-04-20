using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMVC.Models
{
    public class TovarMvcModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public object Category { get; set; }
    }
}