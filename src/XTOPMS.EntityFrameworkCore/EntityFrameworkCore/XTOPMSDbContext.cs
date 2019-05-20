using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Extensions;
using System.Diagnostics.Contracts;
using XTOPMS.Authorization.Roles;
using XTOPMS.Authorization.Users;
using XTOPMS.MultiTenancy;
using XTOPMS.Quotations;
using XTOPMS.Projects;
using XTOPMS.SalesAgreements;
using XTOPMS.StockKeepingUnits;
using XTOPMS.Opportunities;
using XTOPMS.Tasks;
using XTOPMS.Documents;
using XTOPMS.Customers;
using XTOPMS.Alibaba;
using XTOPMS.DataSyncServices;
using XTOPMS.Metadata;

namespace XTOPMS.EntityFrameworkCore
{
    public class XTOPMSDbContext : AbpZeroDbContext<Tenant, Role, User, XTOPMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        // 在这里声明需要创建的实体类所对应的表
        // 通过执行 dotnet ef migrations add <table_name> -v 来创建生成对应表的 migrations 方法
        // 通过执行 dotnet ef datebase update -v 来执行数据库表的更新
        public DbSet<Opportunity> Opportunity { get; set; }
        public DbSet<Quotation> Quotation { get; set; }
        public DbSet<SalesAgreement> SalesAgreement { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<SKU> SKU { get; set; }
        public DbSet<SKUProperty> SKUProperty { get; set; }
        public DbSet<SKUCategory> SKUCategory { get; set; }
        public DbSet<SKUCategoryValue> SKUCategoryValue { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<BusinessCategory> BusinessCategory { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerCategory> CustomerCategory { get; set; }
        public DbSet<CustomerCategorySetting> CustomerCategorySetting { get; set; }
        public DbSet<AccessToken> AccessToken { get; set; }
        public DbSet<DataSyncService> DataSyncService { get; set; }
        public DbSet<XTOPMS.Alibaba.Message> AlibabaMessage { get; set; }
        public DbSet<XTOPMS.Alibaba.ProductCategory> ProductCategory { get; set; }
        public DbSet<CallbackMessage> AlibabaCallbackMessage { get; set; }

        public XTOPMSDbContext(DbContextOptions<XTOPMSDbContext> options)
            : base(options)
        {
        }


        /// <summary>
        /// Ons the model creating.
        /// </summary>
        /// <see cref="https://www.cnblogs.com/Wddpct/archive/2017/05/10/6835574.html"/>
        /// <param name="modelBuilder">Model builder.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Change default table prefix name.
            // modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("Xtopms");
            base.OnModelCreating(modelBuilder);

            // Customer : Category = N : N
            modelBuilder.Entity<CustomerCategorySetting>()
                .HasKey(t => new { t.Id, t.CustomerId, t.CustomerCategoryId });

            modelBuilder.Entity<CustomerCategorySetting>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            modelBuilder.Entity<CustomerCategorySetting>()
                .HasOne(ccs => ccs.Customer)
                .WithMany(c => c.CustomerCategorySettings)
                .HasForeignKey(ccs=>ccs.CustomerId)
                .IsRequired();

            modelBuilder.Entity<CustomerCategorySetting>()
                .HasOne(ccs => ccs.CustomerCategory)
                .WithMany(c => c.CustomerCategorySettings)
                .HasForeignKey(ccs=>ccs.CustomerCategoryId)
                .IsRequired();

        }
    }
}
