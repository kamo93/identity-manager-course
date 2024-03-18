# identity-manager-course
Identity server using dot net identity course net mastery

### Commands run on this project using dotnet cli
``` terminal
dotnet new mvc --language "C#" --name="IdentityManager" --framework="net8.0" -au None -o IdentityManager
dotnet new gitignore
dotnet class -n 'ApplicationDbContext' -o 'Data'
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet new tool-manifest
dotnet tool install --local dotnet-ef
dotnet ef migrations add AddIdentityTables
dotnet ef database udpdate
dotnet new class -n 'ApplicationUser' -o 'Models'
dotnet ef migrations add Extend_user_identity_to_add_name_param
dotnet ef database udpdate
dotnet new class -n 'LoginViews' -o 'Models/Views'
dotnet new class -n 'RegisterViews' -o 'Models/Views'
dotnet tool install --local dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet build // with out this build aspnet-codegenerator would not work
dotnet aspnet-codegenerator view Register Empty -m RegisterViewModel -dc ApplicationDBContext -outDir Views/Account
```

### Links from course
[repo updated](https://github.com/bhrugen/IdentityManager_NET8)

#### Future references for learning
- https://www.youtube.com/watch?v=AopeJjkcRvU&t=1s
