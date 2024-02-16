### Connection to SQLite Database
## Packages: System.Data.SQLite.Core
Name: DAL + project                 name in folders: Database

## 2 Important Properties for Connecting to a Database

```csharp
public static string path = Directory.GetCurrentDirectory() + "\\database.sqlite";
private static SQLiteConnection sqliteconnection
```
## 2 Important Methods for Establishing Connection
```csharp
private static SQLiteConnection DbConnection()
{
    sqliteconnection = new SQLiteConnection("Data Source=" + path);
    sqliteconnection.Open();
    return sqliteconnection;
    // If the database doesn't exist, the method below will handle it
}

public static void CreateSQLiteDatabase()
{
    try
    {
        // If the database doesn't exist, create one
        if (File.Exists(path) == false)
        {
            SQLiteConnection.CreateFile(path);
        }
    }
    catch
    {
        throw;
    }
}
```

## Connection Established, What to Do Now?

  - Create a method to perform CRUD operations in the system
    - How to execute SQL commands in C#
