# To Do API

This is a simple To Do API that allows users to create, read, update, and delete tasks. The API uses JWT tokens for authentication and authorization.

### Installation

Use the Nugget Package Manager to install the following packages:

	- AutoMapper
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.Design
	- Microsoft.EntityFrameworkCore.Sqlite
	- Microsoft.EntityFrameworkCore.Tools
	- Swashbuckle.AspNetCore
	- Microsoft.AspNetCore.Authentication.JwtBeare

## Creating the Database
### Applying Migrations to Database

Run the following command in the 'Package Manager Console' to apply the migrations to the database:

```powershell
$ Update-Database
```