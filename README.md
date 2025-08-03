### ASP.NET Core CRUD Application for Transaction Management

This project is a simple CRUD (Create, Read, Update, Delete) web application for managing financial transactions using ASP.NET Core MVC and Entity Framework Core.

#### Features
- 🏦 Full transaction management (create, view, edit, delete)
- 📅 Automatic date stamping for transactions
- ✅ Model validation for data integrity
- 🗃️ SQL Server database integration
- 📱 Responsive MVC design

#### Technologies Used
- **Backend**: ASP.NET Core 8.0
- **Database**: SQL Server + Entity Framework Core
- **Frontend**: Razor Views, HTML/CSS
- **Validation**: Data annotations

#### Getting Started

1. **Prerequisites**
   - .NET 8 SDK
   - SQL Server (LocalDB, Express, or full version)
   - IDE (Visual Studio 2022)

2. **Setup Database**
   - Update connection string in `appsettings.json`:
     ```json
     "ConnectionStrings": {
       "DevConnection": "Server=.;Database=TransactionDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;"
     }
     ```
   - Run EF Core migrations:
     ```bash
     dotnet ef database update
     ```

3. **Run the Application**
   ```bash
   dotnet run
   ```


#### Project Structure
```
CRUD/
├── Controllers/
│   ├── HomeController.cs       # Basic pages
│   └── TransactionsController.cs # Full CRUD operations
├── Models/
│   ├── Transaction.cs          # Data model
│   ├── TranDbContext.cs        # Database context
│   └── ErrorViewModel.cs
├── Views/                      # Razor views
├── Program.cs                  # Startup configuration
└── appsettings.json            # Configuration
```

#### Transaction Model
```csharp
public class Transaction
{
    [Key]
    public int TranId { get; set; }

    [Required]
    [MaxLength(12)]
    [DisplayName("Account Number")]
    public string AccountNun { get; set; }

    [Required]
    [DisplayName("Beneficiary Name")]
    public string BenName { get; set; }

    [Required]
    [DisplayName("Bank Name")]
    public string BankName { get; set; }

    public int Amount { get; set; }

    [Required]
    [MaxLength(11)]
    [DisplayName("SWIFT Code")]
    public string SwCode { get; set; }

    [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
    public DateTime Date { get; set; }
}
```

#### Key Functionality
- **Create/Edit Transactions**:  
  Combined Add/Edit action using `AddOrEdit()` method
- **Automatic Date Handling**:  
  New transactions automatically get current timestamp
- **Data Validation**:  
  Built-in validation for required fields and lengths
- **EF Core Integration**:  
  Database operations via `TranDbContext`

