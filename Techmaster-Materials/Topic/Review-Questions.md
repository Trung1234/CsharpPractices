# Các câu hỏi, chủ đề ôn tập C#

Các câu hỏi dưới đây được sắp xếp lần lượt theo các chủ đề đã học. Học viên dựa theo khung này trả lời hết các câu hỏi để ôn tập lại kiến thức. Ngoài slides và mã nguồn, tài liệu bổ trợ đều đã được cung cấp rất nhiều, mong các bạn chủ động tìm hiểu để nâng cao kiến thức.  

## Lý Thuyết:
* C# và .NET là gì và khác gì nhau?
* Hai thành phần chính của .NET là gì? Có chức năng gì?
* Giải thích cơ bản quá trình biên dịch của một file C#?
* Từ khóa **using** có tác dụng gì?
* Trong C#, namespace là gì?
* Khi chạy chương trình C# dạng console, hàm nào sẽ được thực thi và có thể gọi nhiều hàm thực thi này một lúc được không?
* Console.Write() và Console.WriteLine() khác gì nhau?
* Hai cách để khai báo biến và gán dữ liệu trong C#?
* Từ khóa **const** có tác dụng gì?
* Các cách chuyển đổi dữ liệu dạng chuỗi sang dạng số nguyên?
* Cách khởi tạo một biến dạng StringBuilder và dùng phương thức gì để nối chuỗi vào biến này?
* Lấy kích thước hay chiều dài của một mảng trong C#? Đặc điểm của kích thước của mảng trong C# là gì?
* Cách sắp xếp một mảng? Cách sắp xếp một mảng theo thứ tự ngược lại?
* Cách chuyển đổi kiểu dữ liệu cho tất cả các phần tử trong một mảng?
* Có một biến số nguyên `int x = 10;`, câu lệnh `x--;` có tác dụng gì và sau câu lệnh này giá trị của `x` là gì?
* Đoạn code sau trả về kết quả gì?
```cs
int x = 10;
int y = 5;
if (x%y == 0 && (x/y)%2 != 0) {
    Console.WriteLine("Option 1");
} else {
    Console.WriteLine("Option 2");
}
```
* Khi dùng vòng lặp `for` và `foreach` với 1 tập hợp dữ liệu, có điểm gì khác nhau giữa 2 kiểu lặp này?
* Từ khóa `break` và `continue` có tác dụng gì và khác gì nhau?
* Một đối tượng (object) là gì? Cách tạo ra một đối tượng?
* Hàm khởi tạo hay `Constructor` là gì? Khi nào hàm này được gọi?  
* `Access modifiers` là gì? `public`, `private`, `internal`, `protected` khác nhau thế nào?
* `static` có ý nghĩa gì? `void` có ý nghĩa gì? 
* Tính đóng gói là gì và cách triển khai tính đóng trong C#?
* Trong C# có đa kế thừa không?
* Làm sao để một lớp con kế thừa từ một lớp cha?
* Hàm `abstract` và hàm `virtual` trong một lớp cha khác gì nhau? Từ khóa nào giúp lớp con viết lại một phương thức kế thừa từ lớp cha?
* `Interface` là gì? Trong một interface có thể định nghĩa và khai báo logic chi tiết của các phương thức không?
* Kế thừa giữa 2 lớp, ví dụ `class Student : class Person`, thường thể hiện mối quan hệ kiểu gì? Còn giữa lớp và interface thường thể hiện mối quan hệ gì?
* Lớp `FileInfo` và `File` khác gì nhau?
* Lớp `StreamWriter`, `StreamReader` có tác dụng gì? Phải lưu ý điều gì khi sử dụng những lớp dạng `Stream` thế này?
* Một tập hợp dạng `List<T>` có thể lưu nhiều kiểu dữ liệu khác nhau được không? kích thước của tập hợp có giới hạn không? 
* LINQ là 1 thư viện có sẵn cho phép ta truy vấn, tương tác với nhiều kiểu dữ liệu bằng C#
