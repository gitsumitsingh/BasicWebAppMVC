using BasicWebCore.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BasicWebCore.Data
{
    public class ApplicationDbContext //: IdentityDbContext<IdentityUser>
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //: base(options)
        //{

        //}
        public ApplicationDbContext() //: base(options)
        {

        }

        public List<Product> Products { get; set; }
    }
}
