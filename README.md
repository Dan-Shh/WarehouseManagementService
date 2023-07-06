# Warehouse management Service

## Used

- dotnet new webapi to quickly create the project
- dotNet 7.0.305
- Microsoft.EntityFrameworkCore.InMemory

## Installation

1. cd to WarehouseManagementService
2. dotnet build
3. dotnet run
4. got to http://localhost:5233/ For Swagger
   For postman call http://localhost:5233/api/abc for example GET http://localhost:5233/api/Products

## Usage

POST a Product to the endpoint and it'll be saved to in-memory DB.
use Either of GET endpoints to fetch
use PUT to update the product
use DELETE to delete the product

## Assumptions/Future enchancements

Since this is a basic conversation starter It's molstly barebones CRUD with in-memory EF storage.
Adding a DTO or a Request / Response models would be a good next step, maybe Automappng between those.
There's no business loginc in here now, and I didn't test EF, but adding tests would be good as well.
There's no auth so that's also good to have.
