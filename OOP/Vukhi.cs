using System;
namespace OOP {
    //các bước khai báo lớp
    //Khai báo phạm vi họat động 
    //Khai báo các thành phần dữ liệu ( thuộc tính , biến )
    // Khai báo cá thành phần hàm (phương thức )
    // Mac dinh k khai baos pham vi thi no la internal

    

    class Vukhi {
        // khai bao pham vu truy cap
        // => trong cac lop luon co phuon thuc khoi tao


 // Du lieu trong bien
        // protected : chi cho truy cap trong pham vi lop hoac lop ke thua
        // internal : chi truy cap duoc trong cung assembly 

        public string name = "ten vu khi";

        int satthuong = 0;

        public Vukhi() {
            satthuong = 1;
             Console.WriteLine("Khoi tao");
        }
        public Vukhi(string name, int _dostathuong) {
            satthuong = _dostathuong;
            this.name = name;
        }

        public Vukhi(string abc) {
            Console.WriteLine(abc);
        }

        //Khai bao phuong thuc trong lop 
        public void ThietLapDoSatThuong(int dosatthuong) {

            //su dung tham chieu bang cach su dung toan tu this tham chieu tơi doi tượng hiện tại của lớp

            // this -> tham chiếu (ref) đối tượng hiện tại

            // this -> ref 
            // Vu khi abc
            // abc = this 

            this.satthuong = dosatthuong;
        }    

        public void Tancong () {
            Console.WriteLine(this.name);
            for(int i = 0; i < satthuong; i++) {
                Console.Write(" * ");
            }
        }  

    }

}