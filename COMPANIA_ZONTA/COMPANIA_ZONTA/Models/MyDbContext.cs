using Microsoft.EntityFrameworkCore;
namespace COMPANIA_ZONTA.Models

{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    }
}
