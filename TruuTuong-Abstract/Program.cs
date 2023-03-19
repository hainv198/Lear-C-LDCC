using System;
namespace Abstract {

    class Product {
        protected double Price {
            set;
            get;
        }

        public virtual void  ProductInfo() {
            System.Console.WriteLine($"hainv {Price}");
        }

        public void Test() =>ProductInfo();
    }

    class Iphone : Product {
        public Iphone() => Price = 500;
        // override - nap chong phuong thuc -> cho biet phuong thuc nay ghi de nen phuong thuc da khai bao o lop co so

        public override void ProductInfo()
        {
            System.Console.WriteLine("Dien thoai IP");
            base.ProductInfo();
        }
    }
    class Program {
        static void Main(string [] args) {
        
            Iphone i = new Iphone();
            i.Test();

        }
    }
}
