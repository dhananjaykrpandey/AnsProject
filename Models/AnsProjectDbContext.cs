//using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Common;
using System.Configuration;

namespace AnsProject.Models
{
    class AnsProjectDbContext : DbContext
    {
        //public AnsProjectDbContext() : base(new SQLiteConnection(string.Concat(Application.StartupPath, @"\AnsDb.db")).ConnectionString)
        //{

        //}
        public AnsProjectDbContext() :
           base(GetConnection(), false)
        {
        }
        public static DbConnection GetConnection()
        {
           // var connString = new SQLiteConnectionStringBuilder() { DataSource = string.Concat(Application.StartupPath, @"\AnsDb.db")}.ConnectionString;
            var connection = ConfigurationManager.ConnectionStrings["SQLiteConnection"];//ConfigurationManager.ConnectionStrings["SQLiteConnection"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(connection.ProviderName);
            var dbCon = factory.CreateConnection();
            dbCon.ConnectionString = connection.ConnectionString;
            return dbCon;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<MainClasses> MainClassesses { get; set; }
    }
}
