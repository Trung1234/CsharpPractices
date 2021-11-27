# Tranning SQL
### Basic Differences between Stored Procedure and Function in SQL Server
The function must return a value but in Stored Procedure it is optional. Even a procedure can return zero or n values.

Functions can have only input parameters for it whereas Procedures can have input or output parameters.

Functions can be called from Procedure whereas Procedures cannot be called from a Function.

### Advance Differences between Stored Procedure and Function in SQL Server
The procedure allows SELECT as well as DML(INSERT/UPDATE/DELETE) statement in it whereas Function allows only SELECT statement in it.

Procedures cannot be utilized in a SELECT statement whereas Function can be embedded in a SELECT statement.

Stored Procedures cannot be used in the SQL statements anywhere in the WHERE/HAVING/SELECT section whereas Function can be.

Functions that return tables can be treated as another rowset. This can be used in JOINs with other tables.

Inline Function can be though of as views that take parameters and can be used in JOINs and other Rowset operations.

An exception can be handled by try-catch block in a Procedure whereas try-catch block cannot be used in a Function.

We can use Transactions in Procedure whereas we can't use Transactions in Functi
### Database Design Tips: 
 - https://support.microsoft.com/en-us/office/database-design-basics-eb2159cf-1e30-401a-8084-bd4f9c9ca1f5
 - https://www3.ntu.edu.sg/home/ehchua/programming/sql/Relational_Database_Design.html
 - https://www.c-sharpcorner.com/UploadFile/shivprasadk/11-important-database-designing-rules/
 - https://www.astera.com/type/blog/all-you-need-to-know-about-database-design/
## Reference 
 - https://www.sqlservertutorial.net/sql-server-indexes/sql-server-clustered-indexes/
 - https://www.codelean.vn/2019/12/mysql-25-index-chi-muc.html
 - https://viblo.asia/p/su-dung-explain-de-toi-uu-cau-lenh-mysql-BYjv44gmvxpV
 - https://viblo.asia/p/index-duoc-va-mat-gAm5yRXAKdb
 - https://viblo.asia/p/25-tip-de-tang-hieu-suat-cho-cau-lenh-sql-MgNeWXZgkYx
 - #### Optimize query:  https://www.sisense.com/blog/8-ways-fine-tune-sql-queries-production-databases/ 
 - #### Why no many-to-many relationships:  https://stackoverflow.com/questions/7339143/why-no-many-to-many-relationships
 - https://www.c-sharpcorner.com/UploadFile/b926a6/create-crystal-report-step-by-step-using-sql-database-view/
 
