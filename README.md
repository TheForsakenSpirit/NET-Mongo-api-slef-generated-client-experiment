# NET-Mongo-api-slef-generated-client-experiment
Repo with experimental dotnet 6 api on mongoDB and auto generated typescript client

# Requirements

Before start, install [dotnet cli and sdk](https://learn.microsoft.com/uk-ua/dotnet/core/install/)
[Install](https://www.mongodb.com/docs/manual/administration/install-community/) and run mongodb on port:27017

# API

To run api execute 
> dotnet run --project server
Api documentation on http://localhost:5260/swagger

# MongoDB LINQ Aggregation example
[Code link](https://github.com/TheForsakenSpirit/NET-Mongo-api-slef-generated-client-experiment/blob/dd2de155840be0884aff4ae22f9753a17c5a241c/server/Controllers/UserController.cs#L35-L41)

# Auto generated TypeScript client with types, that represent api
> dotnet run --project APIClientGenerator http://localhost:5260/swagger/v1/swagger.json client/intex.cs TypeScript