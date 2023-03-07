Đặc trưng của OOP trong C# 

- Tính đóng gói : Encapsulation -> một nhóm của các thuộc tính, phương thức và các thành phần liên quan khác được coi như một đối tượng độc lập, được gói lại trong một lớp 

- Tính kế thừa : Tạo mới một cái lớp từ một lớp nào đó đã có sẵn 

- Tính đa hình : Nhiều hình dạng tại mỗi ngữ cảnh hoàn cảnh thì nó đóng vai trò khác nhau 

- Tính trừu tượng: 



- Tinh ke thừa giúp ta xây dựng ra các lớp mới bằng cách sử dụng các lớp cũ 
- Trong trường hợp muốn 1 lớp nào đó k đc kế thừa bởi 1 lớp khác 
thì ta sử dụng từ khóa sealed

<!! -------------------- !!>

tham trị là các kiểu dữ liệu kích thước nhỏ, size cố định giá trị lưu trực tiếp trên bộ nhớ Stack. Tham chiếu là kiểu chỉ lưu địa chỉ trên stack và giá trị lưu trên heap. Cả 2 loại bộ nhớ này đều được lưu trên RAM, nó chỉ là khác vùng thôi.

Dữ liệu cấu trúc struct và kiểu dữ liệu liệt kê

Struct là kiểu dữ liệu tham trị

Khai báo kiểu dữ liệu liệt kê 
dùng Enum

- Thay thế phương thức của lớp cơ sở lớp cha: 

Khi khai báo các lớp trong lớp kế thừa ta có thể khai báo một phương thức thay thế phương thức đã được đinh nghĩa trong lớp cha 

- Hoạt động của các phương thức khởi tạo( Constructor )

trong lớp cha ta khai báo phương thức nhưng trong lớp kế thừa k khai báo gì thì nó sử dụng phương thức khởi tạo mặc định
 



