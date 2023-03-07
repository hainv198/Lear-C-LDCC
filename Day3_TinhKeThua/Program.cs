using System;

namespace Day3_TinhKeThua {
    class Program {

        // Tinh ke thua 
        /*
            có 2 lớp A và B
            B kế thừa A 
            A - Là lớp cơ sở lớp cha
            B - Kế thừa -> lớp cpm 

            Class B : A {

            }

        */

        static void Main() {
            System.Console.WriteLine("haimv");

            // sử dụng partial
            SanPham.Product iphone = new SanPham.Product();
            iphone.name = "IPhone 15 promax";
            iphone.price = 15000;

            System.Console.WriteLine(iphone.GetInfo());



            Cat Van = new Cat();
        //    Van.Eat();
        //    Van.ShowInfo();
        }
    }
}