# Codecamp 3 của lớp C# 

Yêu cầu làm tất cả phần quiz và thực hành, gửi link github bài làm.  
## Quiz:
### Câu 1: Lớp trong C# có thể kế thừa nhiều __
A. Class  
B. Interface  
C. Abstract class  
D. Static class

### Câu 2: Đoạn code dưới biến result sẽ có giá trị là gì?
```cs
int grade = 65;
string result = grade > 50 ? "Passed" : "Failed";
```  
A. Passed     
B. Failed  
C. 5  
D. Giá trị của biến grade

### Câu 3. Mảng trong C# bắt đầu bằng index __
A. 1  
B. -1  
C. 0     
D. Không đáp án nào đúng

### Câu 4. Điều nào dưới đây là đúng?
A. Đoạn code trong `finally` được thực hiện trong mọi trường hợp     
B. Có thể có nhiều đoạn code `finally` theo sau `try/ catch`  
C. Đoạn code `finally` có thể nằm trước đoạn `catch`  
D. Đoạn code `finally` có thể trả về kết quả với `return` 

### Câu 5. Cách để lớp `Dog` kế thừa từ lớp `Animal`
A. class Dog extends Animal {...}  
B. class Dog inherits Animal {...}  
C. class Dog => Animal {...}  
D. class Dog : Animal {...}    

### Câu 6. Trong lớp Animal, đâu là hàm khởi tạo hay constructor 
A. public constructor Animal () {}  
B. public Animal {}  
C. public Animal () {}    
D. static void Animal () {}  

### Câu 7. Đoạn code dưới đây trả về kết quả gì
```cs
   class test
   {
       public void print()
       {
           Console.WriteLine("Csharp");
       }
   }
   class Program
   {
       static void Main(string[] args)
       {
           test t;
           t.print();
       }
   }
```
A. Code chạy thành công, không in gì ra console hết  
B. Code chạy thành công và in `CSharp` ra console  
C. Gặp lỗi vì biến t    
D. Không có đáp án nào ở trên đúng

### Câu 8. Có 1 file `myDoc.txt`, làm sao để đọc thời gian file này được tạo trong C#
A.    
```cs
FileInfo myDoc = new FileInfo(@"C:\Users\Admin\Desktop\myDoc.txt");
Console.WriteLine(myDoc.CreationTime);
```
B. 
```cs
File myDoc = new File(@"C:\Users\Admin\Desktop\myDoc.txt");
Console.WriteLine(myDoc.CreationTime);
```
C.
```cs
Console.WriteLine(FileInfo.CreationTime(@"C:\Users\Admin\Desktop\myDoc.txt"));
```
D.
```cs
FileInfo myDoc = new FileInfo(@"C:\Users\Admin\Desktop\myDoc.txt");
Console.WriteLine(myDoc.Create());
```

### Câu 9. Đoạn code dưới đây trả về kết quả gì?
```cs
List<int> numbers = new List<int>() {100, 7, 23, 4, 9, 0};
var a = numbers.Find(item => item%2 == 0);
foreach (var item in a){
    Console.Write(item);
    Console.Write(" ");
}
```
A. 100 7 23 9 0  
B. 100 4 0    
C. 7 23 9  
D. 100 7 4 0 

**4 câu hỏi tiếp theo (câu 10 đến câu 13) là về LINQ, ta có 1 mảng dữ liệu như sau**

```cs
string[] colors = { "green", "brown", "blue", "red" };
```

### Câu 10. Đoạn code dưới đây trả về kết quả gì?
```cs
colors.Max (c => c.Length)
```
A. 5  
B. green    
C. brown  
D. Ném ra lỗi

### Câu 11. Biến query trong đoạn code dưới đây có kiểu dữ liệu là gì?
```cs
var query = from c in colors where c.Length > 3 orderby c.Length select c;
```
A. int  
B. string    
C. IEnumerable<string>    
D. IQueryable<string>  

### Câu 12. Đoạn code dưới đây trả về kết quả gì?
```cs
var query = from c in colors where c.Length == colors.Max (c2 => c2.Length) select c;

foreach (var element in query)
  Console.WriteLine (element);
```
A. green brown    
B. 5 5    
C. Lỗi biên dịch (compile-time error)    
D. Ném ra ngoại lệ (throw exception)

### Câu 13. Đoạn code dưới đây trả về kết quả gì?
```cs
var query = colors.Where (c => c.Contains ("e")).Where (c => c.Contains ("n"));

Console.WriteLine (query.Count());
```
A. 1    
B. 2    
C. 3    
D. 4

### Câu 14. Khi kế thừa, lớp con trong cùng 1 assembly có thể kế thừa những thành viên nào của lớp cha
A. static, public, private  
B. public, protected, internal   
C. private, public, internal  
D. static, private, internal  

### Câu 15. Đoạn code dưới đây trả về kết quả gì?
```cs
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.FirstOrDefault(val => val > 2.3);
```
A. Giá trị mặc định cho double là `0.0d`  
B. 2.2  
C. Không gì cả. FirstOrDefault sẽ ném ra ngoại lệ  
D. 2.3

### Câu 16. Biến result sẽ gồm những số nào?
```cs
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
List<int> filter = new List<int> { 1, 1, 2, 3, 5, 8 };
IEnumerable<int> result = ints.Intersect(filter);
```
A. 1 2 8  
B. 1 2 3  
C. 1 1 2 2 8   
D. 1 2 4 8

## Thực Hành:

### Bài 1: Có 1 mảng dữ liệu dưới đây, sắp xếp danh sách thành phố theo độ dài sau đó xếp theo thứ tự A-Z:
```cs
// mảng dữ liệu ban đầu
string[] cities =  
{  
    "ROME","ZURICH","AMSTERDAM","SAIGON", "LONDON","HANOI","CALIFORNIA", "PARIS"  
};  
```
```cs
// in ra kết quả thứ tự
ROME 
HANOI
PARIS
LONDON
SAIGON
ZURICH
AMSTERDAM
CALIFORNIA
```

### Bài 2: Viết 1 phương thức kiểm tra 2 tập hợp dữ liệu: sử dụng LINQ không dùng vòng lặp
```cs
// Phương thức dưới đây trả về True khi tất cả các phần tử trong tập hợp squares
// bằng với bình phương của các phần tử trong tập hợp numbers
/* Ví dụ Test cases:
TestForSquares({1, 2, 3, 4, 5}, {1, 4, 9, 16, 25}) -> True
TestForSquares({1, 2, 5}, {1, 4, 9}) -> False
TestForSquares({}, {}) -> True
TestForSquares({1, 5, 3}, {1, 25, 9, 9}) -> False
*/
public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
{
    return //....;
}
```

### Bài 3: Viết 1 phương thức kiểm tra tập hợp dữ liệu: sử dụng LINQ không dùng vòng lặp
```cs
// Cho 1 tập hợp các chuỗi, lọc sao chỉ còn các phần tử có kí tự 'e',
// sau đó sắp xếp các từ theo thứ tự chữ cái A->Z, rồi trả về kết quả như sau
// trả về 1 câu như sau với <word> là từ cuối cùng trong tập hợp đã đc sắp xếp ở trên:
//  "The last word is <word>"
// Nếu không có phần tử nào chứa 'e', thì trả về null.
/* Ví dụ Test cases:
GetTheLastWord({he,she,it,we,you,they}) -> The last word is we
GetTheLastWord({hop,top,stop,cop,lop,chop}) -> null
 GetTheLastWord({hieu,em,anh,con,phep,tet}) -> The last word is tet
*/
public static string GetTheLastWord(IEnumerable<string> words)
{
    return ;
}
```



