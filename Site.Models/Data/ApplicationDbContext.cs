using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Site.Models.Models.V1.Customers;
using Site.Models.Models.V1.Employees;
using Site.Models.Models.V1.Orders;
using Site.Models.Models.V1.Products;
using Site.Models.Models.V1.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Site.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) 
        {
        
        }

        
        #region Employees
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<EmployeeAddress> EmployeesAddress { get; set; } 
        public DbSet<EmployeePhone> EmployeesPhones { get; set; }
        #endregion

        #region Customers
        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomersAddresses { get; set; }
        public DbSet<CustomerPhone> CustomerPhones { get; set; }
        #endregion

        #region Products
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductList> ProductLists { get; set; }
        #endregion

        #region Settings
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        #endregion

        #region Orders
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderShip> OrderShips { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            #region Employee
            modelBuilder.Entity<EmployeeAddress>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .IsRequired();

            modelBuilder.Entity<EmployeePhone>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .IsRequired();
            #endregion

            #region Customer
            modelBuilder.Entity<Customer>()
                .HasOne(e => e.Company)
                .WithMany()
                .HasForeignKey(e => e.CompanyId)
                .IsRequired();

            modelBuilder.Entity<CustomerAddress>()
                .HasOne(e => e.Customer)
                .WithMany()
                .HasForeignKey(e => e.CustomerId)
                .IsRequired();

            modelBuilder.Entity<CustomerPhone>()
                .HasOne(e => e.Customer)
                .WithMany()
                .HasForeignKey(e=>e.CustomerId)
                .IsRequired();
            #endregion

            #region Product
            modelBuilder.Entity<Product>()
                .HasOne(e => e.Category)
                .WithMany()
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasOne(e => e.SubCategory)
                .WithMany()
                .HasForeignKey(e => e.SubCategoryId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            modelBuilder.Entity<ProductList>()
                .HasOne(e => e.Product)
                .WithMany()
                .HasForeignKey(e => e.ProductId)
                .IsRequired();

            modelBuilder.Entity<ProductList>()
                .HasOne(e => e.Store)
                .WithMany()
                .HasForeignKey(e => e.StoreId)
                .IsRequired();

            modelBuilder.Entity<ProductList>()
                .HasOne(e => e.UnitType)
                .WithMany()
                .HasForeignKey(e=>e.UnitId)
                .IsRequired();

            modelBuilder.Entity<SubCategory>()
                .HasOne(e => e.Category)
                .WithMany()
                .HasForeignKey(e => e.CategoryId)
                .IsRequired();
            #endregion

            #region Orders

            modelBuilder.Entity<Order>()
                .HasOne(e => e.OrderType)
                .WithMany()
                .HasForeignKey(e => e.OrderTypeId)
                .IsRequired();
            
            modelBuilder.Entity<Order>()
                .HasOne(e => e.Employee)
                .WithMany()
                .HasForeignKey(e => e.EmployeeId)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .HasOne(e => e.Customer)
                .WithMany()
                .HasForeignKey(e => e.CustomerId)
                .IsRequired();

            modelBuilder.Entity<OrderItem>()
                .HasOne(e => e.Order)
                .WithMany()
                .HasForeignKey(e => e.OrderId)
                .IsRequired();
            modelBuilder.Entity<OrderDetail>()
                .HasOne(e => e.Order)
                .WithMany()
                .HasForeignKey(e => e.OrderId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();
            modelBuilder.Entity<OrderShip>()
                .HasOne(e => e.Order)
                .WithMany()
                .HasForeignKey(e => e.OrderId)
                .IsRequired();
            #endregion

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=StoreDB;Integrated Security=True;TrustServerCertificate=True;User ID=sa; Password=Sygzalp09102016..; MultipleActiveResultSets=true;");
        }

        //If you make Project Models with Class Library, this following code is run Dotnet Migration Process  
        public class BloggingContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        {
            public ApplicationDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=StoreDB;Integrated Security=True;TrustServerCertificate=True;User ID=sa; Password=Sygzalp09102016..; MultipleActiveResultSets=true;");

                return new ApplicationDbContext(optionsBuilder.Options);
            }
        }
    }
}
