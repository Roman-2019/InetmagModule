using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopAPI.Models
{
    public class TovarApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryApiModelId { get; set; }
        public virtual CategoryApiModel CategoryApiModels { get; set; }

    }
}