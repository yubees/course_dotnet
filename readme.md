dotnet new sln -o Course


dotnet new classlib -o Course.Contracts


dotnet new webapi -o Course

dotnet sln add .\Course\ .\Course.Contracts\


dotnet build


dotnet add .\Course\ reference .\Course.Contracts\ 



dotnet run --project .\Course\