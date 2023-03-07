using System;

namespace Day3_TinhKeThua {

    // Khai bao lop cha
    class Animal {


        // Hoat dong khoi tao Constructor cua lop
    public Animal() {
        System.Console.WriteLine();
    }

    public Animal( string abc) {
        System.Console.WriteLine($"Khoi tao Animal 2 {abc}");
    }


        public int Legs {
            set; 
            get;
        }

        public float Weight {
            set;
            get;
        }

        public void ShowLegs () {
            System.Console.WriteLine($"legs : {Legs}");
        }
    }
    
    
    
    // Khai bao lop con 
    class Cat : Animal {
        //khai bao truong du lieu
        public string Food;
        // Khai bao phuong thuc
        public void Eat() {
            System.Console.WriteLine(Food);
        }
        
        
        // khai bao phuong thuc thay thế lớp cơ sở lớp cha
        public new void ShowLegs() {
            System.Console.WriteLine($"Loai meo cos so chan la {Legs}");
        }

        public void ShowInfo() {
            // để truy cập vào các thuộc tính ở lớp cơ sở ta dùng từ kháo base
            base.ShowLegs();

            // thực hiện show ra thuộc tính ở lớp cơ sở trc rồi show ra thuộc tính thay thế 
            ShowLegs();
        }
        // Muon phuong thuc khoi tao cua lop ke thua thi hanh thi trc tiên phải thi hành một phương thức khởi tạo nào đó của lớp cha
        // dùng :base
        public Cat() :base("abc") {
            this.Legs = 4;
            this.Weight = 300;
            this.Food = "Hat";
        }
    }
}