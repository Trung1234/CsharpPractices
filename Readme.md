 ## References: 
 - ### Rules for writing and reviewing code
   <details>
    <summary>Click to expand</summary>

   -  #### Rule 1: Does that code fulfill  requirements    
   -  #### Rule 2: Formatting is king
   -  #### Rule 3: Don't Repeat Yourself => generalize by abstract class, interface, generic, method
   -  #### Rule 4: Follow the Coding convention
   -  #### Rule 5: Be Consistent with source code (có tính thống nhất)
   -  #### Rule 6: Does Code run fast (For example use Eager loading to load related entities )
   -  #### Rule 7: Avoid Security Pitfalls (SQL Injection, cross-site scripting)
   -  #### Rule 8: Use Efficient Data Structures and Algorithms
   -  #### Rule 9: Comment and Document
   -  #### Rule 10: Check for Errors and Respond to Them
   -  #### Rule 11: Create meaningful names
   -  #### Rule 12: Avoid Deep Nesting
   -  #### Rule 13: Use ternary operator instead of If else
   -  #### Rule 14: Do not hard code (Avoid Magic Number-> use Constants and Enum) https://stackoverflow.com/questions/47882/what-is-a-magic-number-and-why-is-it-bad)
   -  #### Rule 15: Follow SOLID Principles
   -  References: 
      -  ### https://www.informit.com/articles/article.aspx?p=2223710
      -  ### https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
      -  ### https://code.tutsplus.com/tutorials/top-15-best-practices-for-writing-super-readable-code--net-8118
  </details>  
  
  -  #### Architecture and Design Pattern: https://github.com/Trung1234/Csharp4/tree/main/ArchitecturePractice
  -  #### MVC Best Practice: https://github.com/Trung1234/Csharp4/tree/main/MVCBestPractice
  -  #### SQL Best Practice: https://github.com/Trung1234/Csharp4/tree/main/SQlPractice
  -  https://haodev.wordpress.com/2021/03/25/devup-chicken-soup-for-developers/
  -  #### Data encryption: https://tedu.com.vn/bao-mat/tong-quan-cac-loai-thuat-toan-ma-hoa-du-lieu-106.html
  -  Bscrypt: https://jasonwatmore.com/post/2020/07/16/aspnet-core-3-hash-and-verify-passwords-with-bcrypt
  -  #### Has256: https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/
  -  ####  == and Equals(): https://www.c-sharpcorner.com/UploadFile/3d39b4/difference-between-operator-and-equals-method-in-C-Sharp/
  -  ### Pass a number of arguments : https://www.c-sharpcorner.com/UploadFile/c63ec5/use-params-keyword-in-C-Sharp/
  -  #### String and StringBuilder: https://www.c-sharpcorner.com/UploadFile/19b1bd/comparison-of-string-and-stringbuilder-in-C-Sharp/
  -  https://www.c-sharpcorner.com/UploadFile/b926a6/create-crystal-report-step-by-step-using-sql-database-view/ 
  -  #### Callback: https://toidicodedao.com/2015/02/10/series-c-hay-ho-callback-trong-c-delegate-action-predicate-func/
-  #### Unit test: https://trungsieunhan24blog.wordpress.com/2018/06/12/unittest-va-cach-viet/
      - Use AxoCover to display sequence and branch coverage in the code editor: https://marketplace.visualstudio.com/items?itemName=axodox1.AxoCover
      - Xunit https://www.c-sharpcorner.com/article/implementing-unit-and-integration-tests-on-net-with-xunit/
           + To generate coverage report : Tools -> NuGet Package Manager -> Package Manager Console 
               + dotnet test --collect:"XPlat Code Coverage"
               + reportgenerator -reports:"YourGeneratedXML" -targetdir:"coveragereport" -reporttypes:Html
- ### Async
  <details>
    <summary>Click to expand</summary>
 
   -  #### Task: https://www.c-sharpcorner.com/UploadFile/dacca2/asynchronous-programming-in-C-Sharp-5-0-part-3-understand-task/
   -  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
  </details>
  
- ### Linq
  <details>
    <summary>Click to expand</summary>
 
   -  https://www.c-sharpcorner.com/UploadFile/a20beb/ienumerable-vs-iqueryable-in-linq/k/
   -  https://trungsieunhan24blog.wordpress.com/2018/10/30/3-loa%cc%a3i-excution-trong-linq/
   -  https://tedu.com.vn/lap-trinh-c/su-khac-nhau-giua-ienumerable-va-iqueryable-35.html
   -  #### Earger loading: https://tedu.com.vn/lap-trinh-aspnet/tim-hieu-ve-lazyloading-va-earger-loading-trong-entity-framework-120.html
   -  #### Left join: https://www.c-sharpcorner.com/blogs/working-with-left-outer-join-using-lambda-and-linq
  </details>

-  ### 	Relationship : https://www.c-sharpcorner.com/UploadFile/b1df45/dependency-generalization-association-aggregation-compos/
-  ### 	Custom Authentication In ASP.NET Core 3.1 : https://www.c-sharpcorner.com/article/login-and-role-based-custom-authentication-in-asp-net-core-3-1/
-  ### 	Export
   -  #### Excel: https://help.syncfusion.com/wpf/datagrid/export-to-excel
   -  #### Epplus: https://www.c-sharpcorner.com/article/import-and-export-data-using-epplus-core/
   -  #### Pdf: https://www.dotnetspider.com/resources/29759-Exporting-GridView-PDF.aspx
-  ### 	Using Delegates to Communication Between Windows Forms  
   -  https://www.c-sharpcorner.com/article/using-delegates-to-communication-between-windows-forms/
-  ### Upload and Read Excel File:  
   -  https://www.codingvila.com/2021/02/upload-and-read-excel-file-in-web-api.html
-  ### EntityFramework:  
   -  #### Fluent Api: https://trungsieunhan24blog.wordpress.com/2018/11/13/cach-dung-fluent-api-de%CC%89-thay-do%CC%89i-mo-hinh-quan-he%CC%A3/
   -  #### Cascade Delete: https://docs.microsoft.com/en-us/ef/core/saving/cascade-delete
   -  #### Tracking:  https://docs.microsoft.com/en-us/ef/core/querying/tracking
   -  #### Index: https://docs.microsoft.com/en-us/ef/core/modeling/indexes?tabs=data-annotations
   -  #### Relationship: https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=data-annotations%2Cfluent-api-simple-key%2Csimple-key#required-and-optional-relationships
- ## Code review guidelines:
  - https://www.michaelagreiler.com/code-review-checklist-2/
  - https://www.c-sharpcorner.com/article/important-tips-to-write-clean-code-in-visual-studio/
  - https://tedu.com.vn/thu-thuat-lap-trinh/7-buoc-de-thuc-hien-code-review-104.html
- ## Interview Tips:   
  - https://www.c-sharpcorner.com/UploadFile/puranindia/ASP-NET-MVC-Interview-Questions/
  - https://www.c-sharpcorner.com/UploadFile/puranindia/C-Sharp-interview-questions/
  - https://www.c-sharpcorner.com/UploadFile/65794e/sql-interview-questions/
  - https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
- ## Interview with C# Corner MVP Ankit Sharma:
  - https://docs.microsoft.com/en-us/archive/blogs/wikininjas/interview-with-a-asp-net-wiki-ninja-and-c-corner-mvp-ankit-sharma


The Importance of Knowing Patterns
This post is more dedicated to beginners who do not yet understand what is the point of learning and using patterns.

Initially, I also didn’t understand what was the point of using some kind of design pattern in the code - after all, you can just write everything as you want 🤪

And then it turned out that there was a lot of repeating code, just an unrealistically large number of dependencies - and the whole trash was that when changes were made, something else broke 😵

 But to solve this whole problem, to distribute the code into classes, interfaces and make normal inheritance - that's exactly what design patterns exist for.

Patterns are already ready-made solutions to the problem and depend on what kind of task we are facing.

So if you are a beginner - and you want to make your code clean, understandable, structured - I recommend that you study design patterns 🤘
