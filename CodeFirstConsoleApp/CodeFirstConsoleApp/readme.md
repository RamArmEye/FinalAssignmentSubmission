You can access and query your SQL Server database (like StudentDB) from the command line using a couple of different tools depending on what you have installed. Here are the easiest and most common ways:

Option 1: Use sqlcmd (Official SQL Server CLI Tool)
Step 1: Check if sqlcmd is installed

Open Command Prompt and type:

sqlcmd -?

If you see help output, it’s installed. If not, you can install it via:

    Microsoft ODBC Driver + Command Line Utilities

    Or use winget:

winget install Microsoft.SQLCMD

Step 2: Connect to LocalDB

sqlcmd -S (localdb)\mssqllocaldb -d StudentDB -E

    -S = Server name

    -d = Database name

    -E = Use Windows Authentication

     (localdb)\mssqllocaldb is the default for EF in local development.

Step 3: Run a Query

Once you're inside the prompt (1>), try:

SELECT * FROM Students;
GO

To exit:

EXIT

Option 2: Use dotnet-ef CLI (for migrations/inspections)

If you're using Entity Framework Core, you can use the EF CLI to inspect the database model (not query data directly, but useful for checking setup).
Install EF CLI globally:

dotnet tool install --global dotnet-ef

Check the database context:

dotnet ef dbcontext list

    Not used for querying, but useful for dev workflows (like migrations).

Bonus Tip: Use SQL Server Management Studio (SSMS)

If you're more comfortable with GUIs, install SSMS from here, then connect to:

(localdb)\mssqllocaldb

You'll find your StudentDB and the Students table there.
