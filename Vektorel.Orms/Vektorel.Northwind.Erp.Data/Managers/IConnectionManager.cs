namespace Vektorel.Northwind.Erp.Data.Managers;

public interface IConnectionManager : IDisposable
{
    void CreateConnection();
}