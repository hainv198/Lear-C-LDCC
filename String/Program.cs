using System;
namespace String {
    class Program {
    

        public static int Tich(int a, int b) 
        {
            int result;
            result = a* b;
            return result;
        }

        static void Main() {

            String.Program.Tich(4 ,5 ); 
            String.Program.XinChao();
            String.TinhToan.Tong(2,6);

            var kq = TinhToan.Tong(23, 34);
            Console.WriteLine(kq);

            float a = 12.43f;
            float b = 10.43f;
            var tich = TinhToan.Tong(a, b);

            Console.WriteLine("hainv");
        }

        // truyền tham số với tên phương thức
        // Tham số Tham chiếu tham trị 

        // Ví dụ giá trị A đc gán cho giá trị X trong một phương thức
        // Muốn giá trị X tham chiếu tới giá trị A đc gán thì ta sử dụng từ ref
        // khi giá trị X thay đổi thì giá trị gán là A cũng thay đổi 
        // từ khóa ref thì giá trị đó phải được khởi tạo trc 
        // từ khóa out thì không phải khởi tạo trc và chỉ xuất giá trị đó ra thôi 
        // trong OOP các tham số là đối tượng lớp thì mặc định nó là tham chiếu

        static void XinChao() {
            Console.WriteLine("Xin chao Hainv");
        }
    }
}