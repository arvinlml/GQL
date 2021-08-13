# Readme

This workshop based code is a reference from https://github.com/ChilliCream/graphql-workshop

### Sqlite database migration
https://github.com/ChilliCream/graphql-workshop/blob/master/docs/1-creating-a-graphql-server-project.md#option-2---command-line

If you already have ef toolkit then run the following 
```
dotnet build GraphQL
dotnet ef migrations add Initial --project GraphQL
dotnet ef database update --project GraphQL
```

If you dont have the ef toolkit setup, please do the following and then run the above migration step

```
dotnet new tool-manifest
dotnet tool install dotnet-ef --version 5.0.0 --local
```

