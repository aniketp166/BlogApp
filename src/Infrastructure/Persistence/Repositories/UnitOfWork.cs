using Domain;

namespace Infrastructure;

public class UnitOfWork(BlogDbContext context) : IUnitOfWork
{
    public void commit()
    {
        context.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await context.SaveChangesAsync();
    }
}
