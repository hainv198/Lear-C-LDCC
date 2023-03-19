using System;
namespace Generic {
    class Program {


        // Tao Generic trong lop
        class Product<A> {
            A ID;
            public void SetID(A _ID) {
                this.ID = _ID;
            }

            public void PrintIn() {
                System.Console.WriteLine($"ID = {this.ID}");
            }
        }



        static void Grneric<T>(ref T x, ref T y) {
            T number;
            number = x;
            x = y;
            number = y;  
        }

        static void Main(string [] args) {
            string a = "AVC";
            string b = "SGFJ";
            System.Console.WriteLine($"Day so noi la {a}, {b}");

            Grneric(ref a, ref b);
            System.Console.WriteLine($"{a},{b}");

            Product<int> spam = new Product<int>();
            spam.SetID(10);
            spam.PrintIn();
        }
    }
}