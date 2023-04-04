using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial_infnet.Service.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server = tcp:booksmanagerserver.database.windows.net,1433; Initial Catalog = rede_social_infnet; Persist Security Info = False; User ID = adminserver; Password = Aulainfnet123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;");
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=rede_social_infnet;Trusted_Connection=True");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
