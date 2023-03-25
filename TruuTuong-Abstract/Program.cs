using System;
namespace Abstract {

    // abstract class Product {
    //     protected double Price {
    //         set;
    //         get;
    //     }

    //     public abstract void  ProductInfo();

    //     public void Test() =>ProductInfo();
    // }

    // class Iphone : Product {
    //     public Iphone() => Price = 500;
    //     // override - nap chong phuong thuc -> cho biet phuong thuc nay ghi de nen phuong thuc da khai bao o lop co so

    //     public override void ProductInfo()
    //     {
    //         System.Console.WriteLine("Dien thoai IP");
    //         base.ProductInfo();
    //     }
    // }

    interface IHinhHoc {
       public double TinhChuVi();

       public double TinhDienTich();
        
    }

    // Trien khai giao dien
    class HinhChuNhat : IHinhHoc
     {
        // khai bao
        public HinhChuNhat(double _a, double _b) {
            a = _a;
            b = _b;
        }
        public double a {
            get;
            set;
        }
        public double b {
            get;
            set;
        }

        public double TinhChuVi() => 2* (a + b);
        public double TinhDienTich() => a * b;
    }
    class Program {
        static void Main(string [] args) {
            // Product B = new Product();
            // Iphone i = new Iphone();
            // i.Test();
            HinhChuNhat h = new HinhChuNhat(4, 9);
            System.Console.WriteLine($"Dien tich hcn {h.TinhChuVi()} Chu vi hcn {h.TinhDienTich}");

        }
    }
}
