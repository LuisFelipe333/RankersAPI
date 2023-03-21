# RankersAPI

## Requirements

- Visual Studio
- .NET 6.0
- SQL SERVER or SQL SERVER EXPRESS 

## TO DO

- If you use SQL Server Express, uncomment the selected line and comment the line below.
![Connectionsqlexpress](https://user-images.githubusercontent.com/71108533/226698736-b46d35a2-c6a1-4cee-ac4c-b5a9365d994c.png)

- If is not the case, just complete the connection string with their respective credentials.
![Connectionsqlserver](https://user-images.githubusercontent.com/71108533/226698864-e3a3b6f6-21d4-40b3-9246-29966a4056ef.png)


- Open the Package manager console
![Package manager console](https://user-images.githubusercontent.com/71108533/225188766-e346e3d7-e678-4604-abf5-08a840a42356.png)

- Execute the next commands
    - dotnet ef migrations add CreateInitial
    - dotnet ef database update

- Run the code
![Run the code](https://user-images.githubusercontent.com/71108533/226699256-ac9d4eaa-4836-4e6a-be5b-81262e7fcd52.png)
