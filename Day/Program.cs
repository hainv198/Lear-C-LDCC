using System;
using System.Linq;
namespace Day
{

    // note Biến và kiểu dữ liệu trong C#

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hainv");

            // Lam viec voi man hinh console & kieu du lieu
            float numb1, numb2;
            string sinput;
            Console.WriteLine("Hay nhap tham so a");
            sinput = Console.ReadLine();
            numb1 = float.Parse(sinput);

            Console.WriteLine("Hay nhap so b");
            sinput = Console.ReadLine();
            numb2 = float.Parse(sinput);
            Console.WriteLine("So a = {0} So b = {1}", numb1, numb2);


            // Toan tu trong C# -> + - * /

            int a = 10;
            int b = 2;
            var ss = (a > b) ? "a lon hon b" : "kiem tra lai dieu kien";
            Console.WriteLine(ss);


            // Swith case 
            int d;
            d = 10;


            switch (d)
            {
                case 0:
                    Console.WriteLine("gia tri a = {0}", d);
                    break;
                case 1:
                    Console.WriteLine("Gia tri a  = {0}", d);
                    break;
                default:
                    Console.WriteLine("Hay kiem tra lai doi so");
                    break;
            }

            int number1, number2;

            Console.WriteLine("Nhap so a");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so B");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Hay chon phep tinh");
            Console.WriteLine("1) Ting tong");
            Console.WriteLine("2) Tinh hieu");
            Console.WriteLine("3) Tinh nhan");
            Console.WriteLine("4) Tinh chia");

        L1: char c;
            c = Console.ReadKey().KeyChar;

            switch (c)
            {
                case '1':
                    Console.WriteLine($"Tong la {number1 + number2}");
                    break;
                case '2':
                    Console.WriteLine($"Hieu la {number1 - number2}");
                    break;
                case '3':
                    Console.WriteLine($"Nhan la {number1 * number2}");
                    break;
                case '4':
                    Console.WriteLine($"Chi la {number1 / number2}");
                    break;
                default:
                    Console.WriteLine($"So a la {number1}, so b la {number2}");
                    goto L1;
                    break;
            }


            // Vong lap for while do while;

            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine($"3 * {i} = {3 * i} ");
            }

            // while ; kiem tra dk logic dung thi thuc hien khoi lenh neu dung thi thu hien kho lenh
            // cho toi khi sai no se dung lai

            // do while : khoi lenh thuc hien trc chayj it nhat 1 lan roi kiem tra dk logic sau neu logic sai se dung laij

            int idName = 1000;

            do
            {
                Console.WriteLine($"phep nha 3 x {idName} = {3 * idName}");
            }
            while (idName <= 10);


            // Cau truc mang trong C#

            int[] arr = { 1, 3, 5, 6, 2, 5, 2, 65, 2, 23, 4, 67, 4 };


            /* for(i = 0;i <= arr.Length;i++)
             {

                 Console.WriteLine(arr[i]);
             }*/
            // ham sap xep trong C#
            Array.Sort(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //Mang 2 chieu la mang co cac dong va cac cot 
            /*
             
                0  1  2

            0   4  5  6
            1   5  8  8 
            2   23 4  4

             */
            // Khai bao mang 2 chieu 

            // gan gia tri
            double[,] numbers = new double[2, 3] { { 1, 3, 4 }, { 5, 7, 8 } };

            int row = 2;
            int col = 3;
            
            for(int f = 0; f< row; f++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(numbers[f,j]);
                    Console.WriteLine(" ");
                }

                Console.WriteLine();
            }
             
        }

    }
}