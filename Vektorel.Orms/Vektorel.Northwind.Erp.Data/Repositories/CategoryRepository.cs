using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.Northwind.Erp.Data.DTOs;
using Vektorel.Northwind.Erp.Data.Entities;
using Vektorel.Northwind.Erp.Data.Managers;

namespace Vektorel.Orms.Erp.Data.Repositories;

public class CategoryRepository : IConnectionManager
{
    private ConnectionManager connectionManager;

    public CategoryRepository()
    {
        CreateConnection();
    }

    public void AddCategory(NewCategoryDTO category)
    {
        var query = @"insert into Categories (CategoryName, Description)
                      values (@Name, @Description)";
        connectionManager.GetConnection().Execute(query, category);
    }

    public void CreateConnection()
    {
        connectionManager = new ConnectionManager();
    }

    public List<Option> GetCategories()
    {
        var query = "select CategoryID as Code, CategoryName as Name from Categories order by Name";
        return connectionManager.GetConnection().Query<Option>(query).ToList();
    }
}
