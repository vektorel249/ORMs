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

    public bool AddCategory(NewCategoryDTO category)
    {
        var countQuery = "select count(0) from Categories where CategoryName = @Name";
        var count = connectionManager.GetConnection().ExecuteScalar<int>(countQuery, category);

        if (count > 0)
        {
            return false;
        }

        var query = @"insert into Categories (CategoryName, Description)
                      values (@Name, @Description)";
        connectionManager.GetConnection().Execute(query, category);

        return true;
    }

    public void CreateConnection()
    {
        connectionManager = new ConnectionManager();
    }

    public List<Option> GetCategoriesAsOptions()
    {
        var query = "select CategoryID as Code, CategoryName as Name from Categories order by Name";
        return connectionManager.GetConnection().Query<Option>(query).ToList();
    }

    public List<CategoryDTO> GetCategories()
    {
        var query = "select CategoryID as Id, CategoryName as Name, Description from Categories order by Name";
        return connectionManager.GetConnection().Query<CategoryDTO>(query).ToList();
    }
}
