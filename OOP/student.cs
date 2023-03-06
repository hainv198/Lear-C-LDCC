using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// bai toan khai bao sinh vien
namespace OOP {
    class Student {
        private string id;
        private string firstName;
    
        private string email;
        private int age;

        public Student()
        {
            
        }
        public Student(string id, string firstName, string email, int age)
        {
            this.id = id;
            this.firstName = firstName;
            this.age = age;
            this.email = email;
        }

        // Cap quyen truy cap thay doi thuoc tinh
        public void SetAge(int newAge) {
            if(newAge < 0 || newAge > 200) {
                Console.WriteLine("Tuoi ban cung cap khong hop le");
            } else {
                age = newAge;
            }
        }

        public int GetAge() {
            return this.age;
        }

        public void SetFirstName(string newFirstname) {
            if(newFirstname.Length > 0 && newFirstname.Length <= 15) {
                this.firstName = newFirstname;
            } else {
                Console.WriteLine("Ten khong hop le");
            }
        }

        public string GetFirstName() {
            return this.firstName;
        }


    }

}