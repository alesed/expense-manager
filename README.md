# PV178 - Expense manager

## Description
- Allows easy work with the registration of income and expenses - will display the current state of money
- Supports work with multiple users
- Allows asynchronous export of the state of income and expenditure of the user to the database, also import this data from the database

## Prerequisites
- Windows OS (10+)
- .NET 6.0
- SQL Server Express [(download link)](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver16)

## How to run
1. Open Expense Manager.sln
2. [Initialize SQL DB](#initialize-ms-sql) with testing data
3. Run application using your IDE

### Initialize MS SQL
1. Press `Win+R` and type `cmd`
2. Create new local database `> sqllocaldb create "MSSQLLocalDB"`
3. Start newly created database `> sqllocaldb start "MSSQLLocalDB"`
4. Move to a root of your project in terminal `...\Expense Manager>`
5. Seed database by running seed.sql script `> sqlcmd -S (localdb)\MSSQLLocalDB -i .\DAL\seed.sql`

## Troubleshooting
`Cannot create file 'C:\Users\alese\ExpenseManagerDB.mdf' because it already exists. Change the file path or the file name, and retry the operation.`

1. Go to your file system, navigate to `Users\<your-user-name>` and delete all files with name ExpenseManagerDB.
2. Execute `> sqllocaldb stop "MSSQLLocalDB"` and `> sqllocaldb stop "MSSQLLocalDB"`
3. Repeat all steps in [Initialize SQL DB](#initialize-ms-sql) again
