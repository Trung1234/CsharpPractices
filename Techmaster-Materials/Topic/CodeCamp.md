# ĐỀ BÀI 

Áp dụng kiến thức trong tuần về C# cơ bản: khai báo biến, chuyển đổi kiểu, xử lý ngoại lệ, dùng mảng, chuỗi xử lý dữ liệu, xử lý điều kiện và vòng lặp.

Yêu cầu chung cho tất cả các bài:
* Đặt tên biến có nghĩa (ví dụ input, result, sum,...) đừng để x, y, z,...
* Chương trình chạy dễ hiểu cho người dùng, dùng `Console.WriteLine` để in các câu lệnh hướng dẫn rõ ràng
* Nhập dữ liệu đầu vào từ terminal
* Có sử dụng try/catch để kiểm tra input hợp lệ
* Dùng 1 console project. Mỗi bài tập viết thành 1 method riêng `static void Factorial(){}`

### Bài 1: Factorial - Tính giai thừa của 1 số:
* Input: 1 số nguyên
* Ouput: trả về giá trị giai thừa. Ví dụ input = 3, giai thừa của 3 là 3! = 1*2*3 = 6

### Bài 2: CountDigits - Đếm tổng của các chữ số của 1 số:
* Input: 1 số nguyên
* Output: Ví dụ input = 111, tổng các chữ số = 1 + 1 + 1 = 3

### Bài 3: Capitalise - Viết hoa chữ cái đầu tiên của các từ trong 1 chuỗi
* Input: 1 chuỗi
* Ouput: chuỗi đầu vào với chữ cái đầu tiên các từ được viết hoa. Ví dụ "this IS a Sentence" => "This Is A Senctence"

### Bài 4: SecondLargest - Tìm số lớn thứ hai trong 1 mảng
* Input: nhiều số nguyên để có 1 mảng số nguyên
* Ouput: giá trị lớn thứ hai trong mảng đó. Ví dụ, [0, 9, -100, 50, 2] => 9

### Bài 5: QuadraticFunc - Giải phương trình bậc hai, ax^2 + bx + c
* Input: 3 số nguyên lần lượt ứng với a, b, c
* Ouput: nghiệm của phương trình