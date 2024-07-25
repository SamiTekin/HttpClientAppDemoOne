using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAppDemoOne.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string StockCode { get; set; }
        public string ProductName { get; set; }
        public string Stock { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double SalePrice { get; set; }
        public double VAT { get; set; }
        public double Discount { get; set; }
        public double DiscountPrice { get; set; }
        public string Currency { get; set; }
    }
}
