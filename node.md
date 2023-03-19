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

- Chuyển kiểu, Ép kiểu trong lớp kế thừa 

Một biến có kiểu là lớp cơ sở thì có thể gán những giá trị được khởi tạo ra từ lớp kế thừa 
và ngược lại một biến từ lớp kế thừa k gán lại được lớp cơ sở 

// Namespace và partial 

- Khai báo và nạp vào component khác giống như react: tạo component mới khai báo namespace nếu muốn sử dụng thì using Tên_namesapce

khai báo ở dưới thì Tên_class.Phương thức : vd=> Name.Main()

- Bên trong namespace ngoài khai báo các thành phần như class struct, emum, interface .. thì nó cũng cho khai báo các namespace con trong nó 
- Để truy cập vào namespace con thì chúng ta chấm từng cấp từ namespace cha-> phương thức
- Nếu muốn khai báo chia nhỏ ra thành nhiều file mã nguồn thì chúng ta khai báo lớp chúng ta cho từ khóa partail trc từ class thì chúng ta có thể hoàn toàn chia nhỏ cái định nghĩa lớp này trên nhiều file code 
- Khai báo một lớp ở bên trong một lớp khác 

// Generic 


// Phương thức ảo (Virtual method), lớp trừu tượng (abstract) và giao diện interface

- Phương thức ảo là phương thức đc định nghĩa trong lớp cơ sở và đc ghi đè trong lớp kế thừa 

- trong lop co so phai cho biet phuong thuc nao la phuong thuc ao

- lớp trừu tượng (abstract) không được dùng để tạo ra các đối tượng, làm cơ sở cho lớp kế thừa 


- interface : 