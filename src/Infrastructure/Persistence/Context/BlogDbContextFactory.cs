using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure
{
    public class BlogDbContextFactory : IDesignTimeDbContextFactory<BlogDbContext>
    {
        public BlogDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogDbContext>();
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Blog;Integrated Security=True;Encrypt=False");
            return new BlogDbContext(optionsBuilder.Options);
        }
    }
}
