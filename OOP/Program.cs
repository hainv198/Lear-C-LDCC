using System;
namespace OOP {
    class Program {
        public static void Main() {

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

            Vukhi sungmay;
            sungmay = new Vukhi("sung than cong", 4);

            sungmay.Tancong();
            

        }
    }
}