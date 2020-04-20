using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBLL.Models
{
    public class TovarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int CategoryModelId { get; set; }
        public virtual CategoryModel CategoryModels { get; set; }
    }
}
