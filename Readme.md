 ## Reference: 

-  https://social.technet.microsoft.com/wiki/contents/articles/36250.asp-net-core-building-online-poll-system.aspx
-  https://www.c-sharpcorner.com/article/import-and-export-data-using-epplus-core/
-  https://www.c-sharpcorner.com/article/important-tips-to-write-clean-code-in-visual-studio/
-  https://www.c-sharpcorner.com/UploadFile/b926a6/create-crystal-report-step-by-step-using-sql-database-view/ 
-  #### Callback: https://toidicodedao.com/2015/02/10/series-c-hay-ho-callback-trong-c-delegate-action-predicate-func/
-  ### 	Async
     -  #### Task: https://www.c-sharpcorner.com/UploadFile/dacca2/asynchronous-programming-in-C-Sharp-5-0-part-3-understand-task/
     -  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/async/
-  ### 	MVC
     -  https://www.c-sharpcorner.com/article/simple-login-application-using-Asp-Net-mvc/
     -  https://tedu.com.vn/lap-trinh-aspnet-core/model-validation-trong-aspnet-core-253.html
     -  #### Life cycle: https://www.c-sharpcorner.com/UploadFile/00a8b7/Asp-Net-mvc-life-cycle/
     -  #### Paging: https://www.reflectionit.nl/blog/2017/paging-in-asp-net-core-mvc-and-entityframework-core
-  ### 	Export
     -  #### Excel: https://help.syncfusion.com/wpf/datagrid/export-to-excel
     -  #### Pdf: https://www.dotnetspider.com/resources/29759-Exporting-GridView-PDF.aspx
-  ### 	Using Delegates to Communication Between Windows Forms  
     -  https://www.c-sharpcorner.com/article/using-delegates-to-communication-between-windows-forms/
-  ### Upload and Read Excel File:  
     -  https://www.codingvila.com/2021/02/upload-and-read-excel-file-in-web-api.html
-  ### .Net Core:  
     -  https://tedu.com.vn/lap-trinh-aspnet-core/co-che-dependency-injection-trong-aspnet-core-256.html
     -  https://www.c-sharpcorner.com/article/login-and-role-based-custom-authentication-in-asp-net-core-3-1/
     -  https://www.dotnettricks.com/learn/aspnetcore/tips-to-secure-aspnet-core-mvc-applications


-  ### EntityFramework:  
     -  #### Fluent Api: https://trungsieunhan24blog.wordpress.com/2018/11/13/cach-dung-fluent-api-de%CC%89-thay-do%CC%89i-mo-hinh-quan-he%CC%A3/
     -  #### Cascade Delete: https://docs.microsoft.com/en-us/ef/core/saving/cascade-delete
     -  #### Tracking:  https://docs.microsoft.com/en-us/ef/core/querying/tracking
     -  #### Index: https://docs.microsoft.com/en-us/ef/core/modeling/indexes?tabs=data-annotations
     -  #### Relationship: https://docs.microsoft.com/en-us/ef/core/modeling/relationships?tabs=data-annotations%2Cfluent-api-simple-key%2Csimple-key#required-and-optional-relationships
-  ### Design Pattern:  
     -  https://www.c-sharpcorner.com/UploadFile/akkiraju/factory-design-pattern-vs-factory-method-design-pattern/
     -  https://www.c-sharpcorner.com/UploadFile/97fc7a/factory-pattern-in-net-with-an-example/
     -  https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
     -  https://www.c-sharpcorner.com/UploadFile/damubetha/decorator-pattern-in-csharp/
-  ### Security:  
     -  https://docs.microsoft.com/en-us/aspnet/core/security/?view=aspnetcore-5.0     
-  ### Performace:  
     -  https://docs.microsoft.com/en-us/ef/core/performance/efficient-querying#tracking-no-tracking-and-identity-resolution
-  ### WPF:  
     -  #### Live Visual Tree : https://docs.microsoft.com/en-us/visualstudio/xaml-tools/inspect-xaml-properties-while-debugging?view=vs-2019
 ## Code review guidelines:
- https://www.michaelagreiler.com/code-review-checklist-2/
- https://tedu.com.vn/thu-thuat-lap-trinh/7-buoc-de-thuc-hien-code-review-104.html
 ## Interview Tips:
- https://www.c-sharpcorner.com/UploadFile/puranindia/ASP-NET-MVC-Interview-Questions/
- https://www.c-sharpcorner.com/UploadFile/puranindia/C-Sharp-interview-questions/
- https://www.c-sharpcorner.com/UploadFile/65794e/sql-interview-questions/
- https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/

 ## Interview with C# Corner MVP Ankit Sharma:
- https://docs.microsoft.com/en-us/archive/blogs/wikininjas/interview-with-a-asp-net-wiki-ninja-and-c-corner-mvp-ankit-sharma
 ## Interview with C# Corner MVP Ankit Sharma:
PARAMETERS	POST	GET
Data Parameters	It does not store and include the data parameters in the URL or anywhere on the client system.	It includes the data parameters in the URL which can store in the browser history and the security of the client can be compromised.
Bookmark	As the data does not include in the URL so there is no concept of Bookmark.	The get request data can be Bookmarked.
Reload the Page	The data will be resubmitted.	The page will be re-executed but not re-submitted. It does not send any request to the host because it is saved in the cache memory.
Security	POST request provides security over the data.	GET request does not provide any security.
Cache	No cache.	There can be many caches.
Data Length	There is no limit for data length.	It has a data length limit of 2048 characters.
Data Type	All data types are allowed.	Only accepts ASCII characters.
Data Visibility	In the POST method, data is not visible to everyone.	Data is visible to everyone in the GET method.
Use	We use the POST method with sensitive data like a password.	GET is used usually with insensitive data.


