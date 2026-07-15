
## Database Structure
The project uses SQL Server LocalDB with two main tables:
- `service_type`
- `service_type_localization`

## Setup Instructions
1. **Database:**
   - Open SQL Server Management Studio (SSMS).
   - Execute `Scripts/Schema.sql` to initialize the table structure.
   - Execute `Scripts/SeedData.sql` to populate the sample data.

2. **Configuration:**
   - Open the `App.config` file in the project.
   - Verify that the `MyDbConnection` connection string is correctly configured for your SQL Server instance.

3. **Running the Application:**
   - Open `LocalizationDemo.sln` in Visual Studio.
   - Press `F5` to build and run the application.
