# ECOCIVICOM (Blazor clone)

A clone for a friend's website. Only for training puposes.\
Uses Blazor Server.\
Works with a SQLite db and Entity Framework Core.

## Usage

Not really ready for now, there's only a navbar and a sample ofn CRUD for random employees object.\
If you really want to make it work (.NET 7 Runtime):

```shell
dotnet ef database update
dotnet build
dotnet watch run
```

## Sources

Source website: [ECOCIVICOM](https://www.ecocivicom.com/)\
Microsoft Learn: [Introduction to Blazor](https://learn.microsoft.com/fr-fr/training/paths/build-web-apps-with-blazor/)\
Documentation: [Blazor](https://learn.microsoft.com/fr-fr/aspnet/core/blazor/?view=aspnetcore-7.0)\
Database Init: [How to use SQLite in Blazor - All Hands on Tech](https://www.allhandsontech.com/programming/blazor/how-to-sqlite-blazor/)\
Mockdata generation: [Mockaroo](https://www.mockaroo.com/)\
Data formatting: [NimbleText](https://nimbletext.com/Live)
