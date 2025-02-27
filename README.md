# Product Management System

**Product Management System** is a simple web application for managing products and categories. It allows users to perform CRUD (Create, Read, Update, Delete) operations on products, manage product categories, and view paginated product listings. This project uses **ASP.NET Core MVC**, **Entity Framework Core**, and **SQL Server** to provide a full-stack solution for managing product data.

The system is designed to be user-friendly and supports features like server-side pagination for large data sets, making it easy to manage products without performance issues.

## Features
- **Product Management**: 
  - Add, Edit, Delete, and View Products.
  - Products can be linked to a specific category.
- **Category Management**: 
  - Create and manage categories.
  - Assign products to categories for better organization.
- **Pagination**: 
  - Server-side pagination ensures that products are loaded in chunks based on the page number and page size, improving the performance of large product lists.
- **Responsive Design**: 
  - The application uses Bootstrap to provide a responsive layout, ensuring it works well across desktop and mobile devices.

## Project Structure

<pre>
ProductApplication /
│
├── Controllers/
│   └── CategoryController.cs      # Controller for managing categories
│   └── ProductsController.cs      # Controller for managing products
│
├── Models/
│   └── Category.cs                # Model class for categories
│   └── Product.cs                 # Model class for products
│
├── Data/
│   └── AppDbContext.cs            # Database context for Entity Framework Core
│
├── Migrations 
│   └── 20250203185833_InitialCreate.cs     # Initial database migration
│   └── 20250203212626_AddCategoryTable.cs  # Migration for adding Category table
│   └── AppDbContextModelSnapshot.cs        # Snapshot of the current database model
│
├── Views/
│   ├── Category /
│   │   └── Create.cshtml          # View for creating a new category
│   │   └── Edit.cshtml            # View for editing a category
│   │   └── Index.cshtml           # View for listing categories
│   ├── Products /
│   │   └── Create.cshtml          # View for creating a new product
│   │   └── Edit.cshtml            # View for editing a product
│   │   └── Index.cshtml           # View for listing products
│   ├── Shared/
│   │       └── _Layout.cshtml     # Layout page (includes site-wide header, footer, and styles)
│   └── _ViewImports.cshtml        # View import settings
│   └── _ViewStart.cshtml          # Default view settings
│   
├── wwwroot/
│   ├── css/
│   │   └── site.css               # Custom CSS styles
│   ├── js/
│   │   └── site.js                # Custom JavaScript functionality
│   └── images/
│       └── logo.png               # Logo for the system
│
└── README.md                      # Project README file
</pre>

## Technologies Used
- **Backend**: ASP.NET Core MVC for web development.
- **Database**: SQL Server and Entity Framework Core for ORM and data management.
- **Frontend**: HTML, CSS, and Bootstrap for styling and responsive design.
- **Version Control**: Git and GitHub for code management and collaboration.


### Prerequisites
Before you begin, make sure you have the following installed:
- **.NET Core SDK** (version 5 or higher).
- **SQL Server** or **LocalDB** for the database.
- A code editor like **Visual Studio** or **Visual Studio Code** (optional).

  
## How to Run the Project


1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/Project-Management-System.git
    ```

2. Open the project: Navigate to the project directory and open the solution file in Visual Studio.

3. Restore NuGet packages:

   Run the following command in Package Manager Console (PMC):
   
   ```bash
   Update-Package -reinstall
   ```

4. Run the application: Press `F5` to build and run the application locally.

5. Browse through the pages:

    - **Category Management**: Manage Category details from the `Category` section.
    - **Product Management**: View and manage Product details from the `Products` section.


## Contributing

Contributions are always welcome! If you'd like to add new features, fix bugs, or suggest improvements, feel free to fork the repository and submit a pull request.

### Steps to Contribute

1. Fork the repository.

2. Create your feature branch:

    ```bash
    git checkout -b feature/your-feature
    ```

3. Commit your changes:

    ```bash
    git commit -m 'Add your feature'
    ```

4. Push to the branch:

    ```bash
    git push origin feature/your-feature
    ```

5. Open a pull request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

---

## Contact

For any inquiries or support, feel free to contact me via:

Email: bhaveshrvisave@gmail.com

GitHub: Bhaveshvisave

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[![ForTheBadge built-with-love](http://ForTheBadge.com/images/badges/built-with-love.svg)](https://GitHub.com/your-username/)
