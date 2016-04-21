using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UploadImage.Models.BaseModels
{
    public class Shoe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string SalePrice { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
    }
}