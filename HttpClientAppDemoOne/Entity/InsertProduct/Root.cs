using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAppDemoOne.Entity.InsertProduct
{
    public class Root
    {
        public string unique { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string buy_price { get; set; }
        public string sale_price { get; set; }
        public string currency_id { get; set; }
        public string vat { get; set; }
        public string discount { get; set; }
        public string vat_included { get; set; }
        public string stock { get; set; }
        public string barcode { get; set; }
        public string slug { get; set; }
        public string stockcode { get; set; }
        public string unit_id { get; set; }
        public object brand_id { get; set; }
        public string warranty_id { get; set; }
        public List<string> category_ids { get; set; }
        public List<string> product_images { get; set; }
        public SeoInformations seo_informations { get; set; }
        public List<SpecialAreaValue> special_area_values { get; set; }
    }
}
