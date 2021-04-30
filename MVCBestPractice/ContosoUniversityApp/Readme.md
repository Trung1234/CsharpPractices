## MVC Web App using .NET Core 3.1 and Entity Framework (EF) Core (DB First)
## Script to gen DB
-  ### 	dotnet ef not found in .NET Core 3
     -  dotnet tool install --global dotnet-ef // https://stackoverflow.com/questions/57066856/dotnet-ef-not-found-in-net-core-3
-  ### 	Create your first migration 
     -  dotnet ef migrations add InitialCreate
-  ###  Create your database and schema  
     -  dotnet ef database update
## ValidateAntiForgeryToken (ngăn chặn các giả mạo yêu cầu trang web chéo)
	- https://helpex.vn/question/validateantiforgerytoken-muc-dich-giai-thich-va-vi-du-5cb7de96ae03f646703be6c0
	
## Refernce
-  https://docs.microsoft.com/vi-vn/aspnet/core/data/ef-mvc/crud?view=aspnetcore-3.1
- https://social.technet.microsoft.com/wiki/contents/articles/51363.asp-net-core-2-0-cookie-authentication.aspx
-  https://forums.asp.net/t/2167230.aspx?showing+modal+pop+up+in+asp+net+mvc+as+partial+view



