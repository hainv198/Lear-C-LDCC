using System;
namespace SanPham {
    public class Product {
        public string name {set; get;}

        public decimal price {set; get;}
        public string GetInfo() {
            return $"{name} / {price}";
        }
    }
}