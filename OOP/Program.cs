using System;
namespace OOP {



    class Program {

        public struct Programs
    {
        public string name;
        public double price;

        // phuong thuc
        public string getName() {
            return $"ten san pham {name}, gia {price}";
        }

        // contructor
        public Programs (string name, double price ) {
            this.name = name;
            this.price = price;
        }
    }

    // Khai báo enum kiểu liệt kê

        enum HocLuc {
            Kem = 3, // default tu 0 -> ,,,.. va co the thiet lap gia tri tuong ung
            TrungBinh,
            Kha,
            Gioi
        }

        public static void Main() {
            
            // Su dung enum danh sach
            HocLuc hocluc;
            hocluc = HocLuc.Gioi;

            switch(hocluc) {
                case HocLuc.Kem:
                    Console.WriteLine("Hoc luv kem");
                    break;

                // todos
            }
            

// Lập trình hướng đối tượng là chia nhỏ các đối tượng mỗi đối tượng có các thuộc tính tính chất 
// và mỗi đối tượng nó ứng sử theo dữ liệu của nos 

            Console.WriteLine("Hainv");

            Vukhi sungluc; // gia tri null

            sungluc = new Vukhi();
            Vukhi sungtruong = new Vukhi("Khoi tao co tham so");

            // De truy cap vao truong du lieu cua mot doi tuong 
            Console.WriteLine(sungluc.name);

            sungluc.ThietLapDoSatThuong(5);
            sungluc.Tancong();

            sungluc.SatThuong = 10;

            Vukhi sungmay;
            sungmay = new Vukhi("sung than cong", 4);

            sungmay.Tancong();

            Student nam = new Student("17B407008", "Hainv", "hai@gmail.com", 20);

            nam.SetAge(23);
            nam.SetFirstName("Phuong QC");
            Console.WriteLine("Tuoi" + nam.GetAge() + nam.GetFirstName());

            
            Programs sanpham1;
            sanpham1.name = "iphone";
            sanpham1.price = 11000;

            Programs namService = new Programs("hainv", 1234);
        }
    }
}