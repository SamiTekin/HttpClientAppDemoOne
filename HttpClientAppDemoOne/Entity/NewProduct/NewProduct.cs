using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientAppDemoOne.Entity.NewProduct
{
    public class NewProduct
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class GetCategory
        {
            public int id { get; set; }
            public int category_id { get; set; }
            public int product_id { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public GetCategory get_category { get; set; }
        }

        public class GetCategory2
        {
            public int id { get; set; }
            public object parent_id { get; set; }
            public string name { get; set; }
            public object description { get; set; }
            public string slug { get; set; }
            public int rank { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class GetSeoInformation
        {
            public int id { get; set; }
            public int product_id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string keywords { get; set; }
            public string index { get; set; }
            public string follow { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class GetUnit
        {
            public int id { get; set; }
            public string name { get; set; }
            public string symbol { get; set; }
            public int increase { get; set; }
            public int type { get; set; }
            public int multiplier { get; set; }
            public int is_default { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class GetWarrant
        {
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
        }

        public class Product
        {
            public int id { get; set; }
            public int warranty_id { get; set; }
            public int unit_id { get; set; }
            public object brand_id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string barcode { get; set; }
            public string stockcode { get; set; }
            public string description { get; set; }
            public int stock { get; set; }
            public int active { get; set; }
            public object discount { get; set; }
            public object vat { get; set; }
            public int is_deleted { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public List<object> get_variants { get; set; }
            public GetSeoInformation get_seo_information { get; set; }
            public object get_price { get; set; }
            public GetWarrant get_warrant { get; set; }
            public GetUnit get_unit { get; set; }
            public List<GetCategory> get_categories { get; set; }
            public List<object> get_discounts { get; set; }
            public List<object> get_variant_items { get; set; }
        }

        public class Root
        {
            public Product product { get; set; }
        }


    }
}
