using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Models
{
    public class TovarCategory
    {
            public IEnumerable<TovarModels> Tovars { get; set; }
            public SelectList Categories { get; set; }
    }
}