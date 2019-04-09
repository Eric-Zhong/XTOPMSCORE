using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using XTOPMS.Authorization.Roles;
using XTOPMS.Authorization.Users;
using XTOPMS.MultiTenancy;
using XTOPMS.Migrations;
using XTOPMS.Quotations;
using System.Diagnostics.Contracts;
using XTOPMS.Projects;
using XTOPMS.SalesAgreements;
using XTOPMS.StockKeepingUnits;
using XTOPMS.Opportunities;
using XTOPMS.Tasks;
using XTOPMS.Documents;
using XTOPMS.Customers;

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
        public DbSet<Customer> Customer { get; set; }

        public XTOPMSDbContext(DbContextOptions<XTOPMSDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Change default table prefix name.
            // modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>("Xtopms");
            base.OnModelCreating(modelBuilder);
        }
    }
}
