using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projekt_Biblioteka.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projekt_Biblioteka.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        

        public DbSet<Book> Book { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<BorrowedList> BorrowedLists { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<BorrowedList>().ToTable("Borrowed");
        }


        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL("server=127.0.0.1;port=3306;user=root;database=biblioteka")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                    .AddConsole()
                    .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
        */


       /* #region Login by username and password store procedure method.  

        /// <summary>  
        /// Login by username and password store procedure method.  
        /// </summary>  
        /// <param name="usernameVal">Username value parameter</param>  
        /// <param name="passwordVal">Password value parameter</param>  
        /// <returns>Returns - List of logins by username and password</returns>  
        public async Task<List<User>> LoginByUsernamePasswordMethodAsync(string loginVal, string passwordVal)
        {
            // Initialization.  
            List<User> lst = new List<User>();

            try
            {
                // Settings.  
                SqlParameter usernameParam = new SqlParameter("@login", loginVal ?? (object)DBNull.Value);
                SqlParameter passwordParam = new SqlParameter("@password", passwordVal ?? (object)DBNull.Value);

                // Processing.  
                string sqlQuery = "EXEC [dbo].[LoginByUsernamePassword] " +
                                    "@username, @password";
                
                lst = await this.Query<>().FromSql(sqlQuery, usernameParam, passwordParam).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Info.  
            return lst;
        }

        #endregion*/
    }
}
