using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NATS.Models
{
    public partial class FrontDoorContext : DbContext
    {
        public FrontDoorContext()
        {
        }

        public FrontDoorContext(DbContextOptions<FrontDoorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Bonus> Bonus { get; set; }
        public virtual DbSet<CarFeatures> CarFeatures { get; set; }
        public virtual DbSet<CarLoans> CarLoans { get; set; }
        public virtual DbSet<CarManufacturers> CarManufacturers { get; set; }
        public virtual DbSet<CarModels> CarModels { get; set; }
        public virtual DbSet<CarsForSale> CarsForSale { get; set; }
        public virtual DbSet<CarsSold> CarsSold { get; set; }
        public virtual DbSet<CustomerPayments> CustomerPayments { get; set; }
        public virtual DbSet<CustomerPreferences> CustomerPreferences { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<EmpDetails> EmpDetails { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<FeaturesOnCarsForSale> FeaturesOnCarsForSale { get; set; }
        public virtual DbSet<FinanceCompanies> FinanceCompanies { get; set; }
        public virtual DbSet<InsuranceCompanies> InsuranceCompanies { get; set; }
        public virtual DbSet<InsurancePolicies> InsurancePolicies { get; set; }
        public virtual DbSet<OneOneDisussion> OneOneDisussion { get; set; }
        public virtual DbSet<Org> Org { get; set; }
        public virtual DbSet<PaymentStatus> PaymentStatus { get; set; }
        public virtual DbSet<ProjectAssignment> ProjectAssignment { get; set; }
        public virtual DbSet<Salgrade> Salgrade { get; set; }
        public virtual DbSet<TimeSheetMaster> TimeSheetMaster { get; set; }
        public virtual DbSet<TimesheetDetail> TimesheetDetail { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }
        public virtual DbSet<VehicleCategories> VehicleCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=DESKTOP-JLVN9AQ\\SQLEXPRESS;database=FrontDoor;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.Property(e => e.AddressId)
                    .HasColumnName("Address_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasColumnName("Address_Line_1")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine2)
                    .IsRequired()
                    .HasColumnName("Address_Line_2")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine3)
                    .IsRequired()
                    .HasColumnName("Address_Line_3")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine4)
                    .IsRequired()
                    .HasColumnName("Address_Line_4")
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerId).HasColumnName("customer_ID");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.Addresses)
                    .HasForeignKey<Addresses>(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_ID");
            });

            modelBuilder.Entity<Bonus>(entity =>
            {
                entity.ToTable("BONUS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comm)
                    .HasColumnName("COMM")
                    .HasColumnType("money");

                entity.Property(e => e.Ename)
                    .HasColumnName("ENAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sal)
                    .HasColumnName("SAL")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<CarFeatures>(entity =>
            {
                entity.HasKey(e => e.CarFeatureId);

                entity.ToTable("Car_Features");

                entity.Property(e => e.CarFeatureId)
                    .HasColumnName("Car_Feature_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AirConditioning).HasColumnName("Air_Conditioning");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CarLoans>(entity =>
            {
                entity.HasKey(e => e.LoanId);

                entity.ToTable("Car_Loans");

                entity.Property(e => e.LoanId)
                    .HasColumnName("Loan_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarSoldId).HasColumnName("Car_Sold_ID");

                entity.Property(e => e.FinanceCompanyId).HasColumnName("Finance_Company_ID");

                entity.Property(e => e.MonthlyRepayments).HasColumnName("Monthly_Repayments");

                entity.Property(e => e.RepaymentEndDate)
                    .HasColumnName("Repayment_End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RepaymentStDate)
                    .HasColumnName("Repayment_St_Date")
                    .HasColumnType("date");

                entity.HasOne(d => d.CarSold)
                    .WithMany(p => p.CarLoans)
                    .HasForeignKey(d => d.CarSoldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Loans_Cars_Sold");

                entity.HasOne(d => d.FinanceCompany)
                    .WithMany(p => p.CarLoans)
                    .HasForeignKey(d => d.FinanceCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Loans_Finance_Companies1");
            });

            modelBuilder.Entity<CarManufacturers>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId);

                entity.ToTable("Car_Manufacturers");

                entity.Property(e => e.ManufacturerId)
                    .HasColumnName("Manufacturer_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ManufacturerFullName)
                    .IsRequired()
                    .HasColumnName("Manufacturer_FullName")
                    .HasMaxLength(200);

                entity.Property(e => e.ManufacturerOtherDetail)
                    .HasColumnName("Manufacturer_OtherDetail")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<CarModels>(entity =>
            {
                entity.HasKey(e => e.CarModelId);

                entity.ToTable("Car_Models");

                entity.Property(e => e.CarModelId)
                    .HasColumnName("Car_Model_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ManufacturerCode).HasColumnName("Manufacturer_Code");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasColumnName("Model_Name")
                    .HasMaxLength(200);

                entity.HasOne(d => d.CarModel)
                    .WithOne(p => p.CarModels)
                    .HasForeignKey<CarModels>(d => d.CarModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Models_Car_Manufacturers");
            });

            modelBuilder.Entity<CarsForSale>(entity =>
            {
                entity.HasKey(e => e.CarForSaleId);

                entity.ToTable("Cars_for_Sale");

                entity.Property(e => e.CarForSaleId)
                    .HasColumnName("Car_for_Sale_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AskingPrice)
                    .HasColumnName("Asking_price")
                    .HasColumnType("money");

                entity.Property(e => e.CurrentMileage)
                    .IsRequired()
                    .HasColumnName("Current_Mileage")
                    .HasMaxLength(20);

                entity.Property(e => e.DateAcquired)
                    .HasColumnName("Date_Acquired")
                    .HasColumnType("date");

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_ID");

                entity.Property(e => e.ModelCode).HasColumnName("Model_Code");

                entity.Property(e => e.RegistrationYear)
                    .IsRequired()
                    .HasColumnName("Registration_Year")
                    .HasMaxLength(4);

                entity.Property(e => e.VehicleCategoryCode).HasColumnName("Vehicle_Category_Code");

                entity.HasOne(d => d.VehicleCategoryCodeNavigation)
                    .WithMany(p => p.CarsForSale)
                    .HasForeignKey(d => d.VehicleCategoryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_for_Sale_Car_Manufacturers");
            });

            modelBuilder.Entity<CarsSold>(entity =>
            {
                entity.HasKey(e => e.CarSoldId);

                entity.ToTable("Cars_Sold");

                entity.Property(e => e.CarSoldId)
                    .HasColumnName("Car_Sold_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgreedPrice)
                    .HasColumnName("Agreed_price")
                    .HasColumnType("money");

                entity.Property(e => e.CarForSaleId).HasColumnName("Car_for_Sale_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.DateSold)
                    .HasColumnName("Date_Sold")
                    .HasColumnType("date");

                entity.Property(e => e.MonthlyPaaymentAmt)
                    .HasColumnName("Monthly_Paayment_Amt")
                    .HasColumnType("money");

                entity.Property(e => e.MonthlyPaymentDate)
                    .HasColumnName("Monthly_Payment_Date")
                    .HasColumnType("date");

                entity.HasOne(d => d.CarForSale)
                    .WithMany(p => p.CarsSold)
                    .HasForeignKey(d => d.CarForSaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Sold_Cars_for_Sale");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CarsSold)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cars_Sold_Customers");
            });

            modelBuilder.Entity<CustomerPayments>(entity =>
            {
                entity.HasKey(e => e.CustomerPaymentId);

                entity.ToTable("Customer_Payments");

                entity.Property(e => e.CustomerPaymentId)
                    .HasColumnName("Customer_Payment_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarSoldId).HasColumnName("Car_Sold_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.CustomerPaymentDateMade)
                    .HasColumnName("Customer_Payment_Date_made")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerPaymentDueDate)
                    .HasColumnName("Customer_Payment_Due_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PaymentStatusCode).HasColumnName("Payment_Status_Code");

                entity.HasOne(d => d.CarSold)
                    .WithMany(p => p.CustomerPayments)
                    .HasForeignKey(d => d.CarSoldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Payments_Payment_Status");
            });

            modelBuilder.Entity<CustomerPreferences>(entity =>
            {
                entity.HasKey(e => e.CustomerPreferenceId);

                entity.ToTable("Customer_Preferences");

                entity.Property(e => e.CustomerPreferenceId)
                    .HasColumnName("Customer_Preference_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarFeatureId).HasColumnName("Car_Feature_ID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("Customer_ID");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Model).HasMaxLength(150);

                entity.HasOne(d => d.CarFeature)
                    .WithMany(p => p.CustomerPreferences)
                    .HasForeignKey(d => d.CarFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Preferences_Car_Features");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPreferences)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cust_ID");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("Customer_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<EmpDetails>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK_Emp");

                entity.Property(e => e.EmpAccountName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.EmpDepartment).HasMaxLength(255);

                entity.Property(e => e.EmpEmail)
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.EmpEmployeeId)
                    .IsRequired()
                    .HasColumnName("EmpEmployeeID")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.EmpFunction)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.EmpName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.EmpType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Address).HasMaxLength(60);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(15);

                entity.Property(e => e.Country).HasMaxLength(15);

                entity.Property(e => e.Extension).HasMaxLength(4);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.HomePhone).HasMaxLength(24);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.PhotoPath).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.Region).HasMaxLength(15);

                entity.Property(e => e.Title).HasMaxLength(30);

                entity.Property(e => e.TitleOfCourtesy).HasMaxLength(25);
            });

            modelBuilder.Entity<FeaturesOnCarsForSale>(entity =>
            {
                entity.HasKey(e => e.CarForSaleId);

                entity.ToTable("Features_on_Cars_for_Sale");

                entity.Property(e => e.CarForSaleId)
                    .HasColumnName("Car_for_Sale_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarFeatureId).HasColumnName("Car_Feature_Id");

                entity.HasOne(d => d.CarFeature)
                    .WithMany(p => p.FeaturesOnCarsForSale)
                    .HasForeignKey(d => d.CarFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Features_on_Cars_for_Sale_Car_Features");
            });

            modelBuilder.Entity<FinanceCompanies>(entity =>
            {
                entity.HasKey(e => e.FinanceCompanyId);

                entity.ToTable("Finance_Companies");

                entity.Property(e => e.FinanceCompanyId)
                    .HasColumnName("Finance_Company_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FinanceCompanyName)
                    .IsRequired()
                    .HasColumnName("Finance_Company_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<InsuranceCompanies>(entity =>
            {
                entity.HasKey(e => e.InsuranceCompanyId);

                entity.ToTable("Insurance_Companies");

                entity.Property(e => e.InsuranceCompanyId)
                    .HasColumnName("Insurance_Company_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InsuranceCompanyName)
                    .IsRequired()
                    .HasColumnName("Insurance_Company_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<InsurancePolicies>(entity =>
            {
                entity.HasKey(e => e.PolicyId);

                entity.ToTable("Insurance_Policies");

                entity.Property(e => e.PolicyId)
                    .HasColumnName("Policy_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarSoldId).HasColumnName("Car_Sold_Id");

                entity.Property(e => e.InsuranceCompanyId).HasColumnName("Insurance_Company_ID");

                entity.HasOne(d => d.CarSold)
                    .WithMany(p => p.InsurancePolicies)
                    .HasForeignKey(d => d.CarSoldId)
                    .HasConstraintName("FK_Insurance_Policies_Cars_Sold");

                entity.HasOne(d => d.InsuranceCompany)
                    .WithMany(p => p.InsurancePolicies)
                    .HasForeignKey(d => d.InsuranceCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Insurance_Policies_Insurance_Companies");
            });

            modelBuilder.Entity<OneOneDisussion>(entity =>
            {
                entity.Property(e => e.DiscussionDate).HasColumnType("datetime");

                entity.Property(e => e.DisucssionUpdatedBy).HasColumnType("datetime");
            });

            modelBuilder.Entity<Org>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Parent)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.HasKey(e => e.PaymentStatusCode);

                entity.ToTable("Payment_Status");

                entity.Property(e => e.PaymentStatusCode)
                    .HasColumnName("Payment_Status_Code")
                    .ValueGeneratedNever();

                entity.Property(e => e.PaymentStatusDesc)
                    .IsRequired()
                    .HasColumnName("Payment_status_Desc")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ProjectAssignment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Salgrade>(entity =>
            {
                entity.ToTable("SALGRADE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.Hisal)
                    .HasColumnName("HISAL")
                    .HasColumnType("money");

                entity.Property(e => e.Losal)
                    .HasColumnName("LOSAL")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TimeSheetMaster>(entity =>
            {
                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(60)
                    .IsFixedLength();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.TimeSheetMaster)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSheetMaster_Employees");
            });

            modelBuilder.Entity<TimesheetDetail>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WorkDay).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActivationKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreatedBy).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtherName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityQuestion)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleCategories>(entity =>
            {
                entity.HasKey(e => e.VehicleCategoryCode);

                entity.ToTable("Vehicle_Categories");

                entity.Property(e => e.VehicleCategoryCode)
                    .HasColumnName("Vehicle_Category_Code")
                    .ValueGeneratedNever();

                entity.Property(e => e.VehicleCategoryDesc)
                    .IsRequired()
                    .HasColumnName("Vehicle_Category_Desc")
                    .HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
