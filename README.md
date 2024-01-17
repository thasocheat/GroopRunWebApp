# GroopRunWebApp



## 🏃 Getting Started

1. Go into directory where you plan on keeping project and run.

```bash
  git fork https://github.com/thasocheat/GroopRunWebApp.git
  or git clone https://github.com/thasocheat/GroopRunWebApp.git
```

2. Create a local database.


3. Add connection string to app settings.json. It will look something like this:
```bash
  Data Source=DESKTOP-EI2TOGP\\SQLEXPRESS;Initial Catalog=GroopsRun;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
```

4. Go to Window PowerShell and type:

- To create the migration file
   ```bash
    Add-Migration InitialCreate 
   ```
- To run and migrate the tables into the database

    ```bash
    Update-Database 
   ```
- 

6. Register for a [Cloudinary Account](https://cloudinary.com/users/register/free) (%100 free) and add Cloudname, ApiKey, and Api secret to appsettings.json.
