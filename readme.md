# Readme

This workshop based code is a reference from https://github.com/ChilliCream/graphql-workshop

### Sqlite database migration
https://github.com/ChilliCream/graphql-workshop/blob/master/docs/1-creating-a-graphql-server-project.md#option-2---command-line

```
dotnet build GraphQL
dotnet ef migrations add Initial --project GraphQL
dotnet ef database update --project GraphQL
```

