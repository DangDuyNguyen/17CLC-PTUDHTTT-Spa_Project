using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpaAPI.Models
{
    public partial class SpaManagementContext : DbContext
    {
        public SpaManagementContext()
        {
        }

        public SpaManagementContext(DbContextOptions<SpaManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bed> Bed { get; set; }
        public virtual DbSet<BookAppointment> BookAppointment { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<ListProduct> ListProduct { get; set; }
        public virtual DbSet<ListProductPreOrder> ListProductPreOrder { get; set; }
        public virtual DbSet<ListService> ListService { get; set; }
        public virtual DbSet<ListServicePreOrder> ListServicePreOrder { get; set; }
        public virtual DbSet<Outlet> Outlet { get; set; }
        public virtual DbSet<PreOrder> PreOrder { get; set; }
        public virtual DbSet<ProductCustomer> ProductCustomer { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<ServiceCustomer> ServiceCustomer { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=SpaManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bed>(entity =>
            {
                entity.Property(e => e.BedId)
                    .HasColumnName("BedID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BedDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BedName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookAppointment>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__BookAppo__3DE0C2279DBF2BAE");

                entity.Property(e => e.BookId)
                    .HasColumnName("BookID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateAppointment)
                    .HasColumnName("Date_Appointment")
                    .HasColumnType("date");

                entity.Property(e => e.DateFoundedAppointment)
                    .HasColumnName("DateFounded_Appointment")
                    .HasColumnType("date");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StatusBook).HasColumnName("Status_Book");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("_Address")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerImage)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Hobbies)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Job)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.Property(e => e.FoodId)
                    .HasColumnName("FoodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Calories)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConsultantId)
                    .IsRequired()
                    .HasColumnName("ConsultantID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date)
                    .HasColumnName("_Date")
                    .HasColumnType("date");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Room)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");
            });

            modelBuilder.Entity<ListProduct>(entity =>
            {
                entity.Property(e => e.ListProductId)
                    .HasColumnName("ListProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<ListProductPreOrder>(entity =>
            {
                entity.HasKey(e => e.ListProductPreOrder1)
                    .HasName("PK__ListProd__6C9A39BF257BED6E");

                entity.Property(e => e.ListProductPreOrder1)
                    .HasColumnName("ListProductPreOrder")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
            });

            modelBuilder.Entity<ListService>(entity =>
            {
                entity.Property(e => e.ListServiceId)
                    .HasColumnName("ListServiceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BedId).HasColumnName("BedID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Time)
                    .HasColumnName("_Time")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListServicePreOrder>(entity =>
            {
                entity.Property(e => e.ListServicePreOrderId)
                    .HasColumnName("ListServicePreOrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Time)
                    .HasColumnName("_Time")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Outlet>(entity =>
            {
                entity.Property(e => e.OutletId)
                    .HasColumnName("OutletID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.OutletAddress)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OutletName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreOrder>(entity =>
            {
                entity.Property(e => e.PreOrderId)
                    .HasColumnName("PreOrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Appointment).HasColumnType("date");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateFounded).HasColumnType("date");

                entity.Property(e => e.ListServicePreOrderId).HasColumnName("ListServicePreOrderID");

                entity.Property(e => e.OutletId).HasColumnName("OutletID");
            });

            modelBuilder.Entity<ProductCustomer>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Product___B40CC6EDF64FE051");

                entity.ToTable("Product_Customer");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.RoomId)
                    .HasColumnName("RoomID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoomDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServiceCustomer>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK__Service___C51BB0EAA8F4E157");

                entity.ToTable("Service_Customer");

                entity.Property(e => e.ServiceId)
                    .HasColumnName("ServiceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BreakTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceImage)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTime)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.TherapistId).HasColumnName("TherapistID");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("_Address")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JoinedDay).HasColumnType("date");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StaffImage)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("_User");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
