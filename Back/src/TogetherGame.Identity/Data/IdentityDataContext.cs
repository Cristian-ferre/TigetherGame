using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TogetherGame.Identity.Data
{
    public class IdentityDataContext :IdentityDbContext
    {
        //Criação do contrutor

        public IdentityDataContext(DbContextOptions<IdentityDataContext> Options) : base(Options)
        {
            
        }
        
    }
}