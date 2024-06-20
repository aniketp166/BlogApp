namespace Domain;

public interface IUnitOfWork
{
    void commit();
    Task CommitAsync();
}
