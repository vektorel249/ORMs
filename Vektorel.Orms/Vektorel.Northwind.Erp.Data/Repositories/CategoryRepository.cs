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

    public bool Add(NewCategoryDTO category)
    {
        // kategori adını ve açıklamayı normalize et
        // "  SPorTs  " => "Sports"
        // "SpoRT STUfFS and Things, " => Sport stufss and things

        var exist = CheckIfExistByName(category.Name, 0);
        if (exist)
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

    public bool Delete(CategoryDTO category)
    {
        var countQuery = "select count(0) from Products where CategoryId = @Id";
        var count = connectionManager.GetConnection().ExecuteScalar<int>(countQuery, category);
        if (count > 0)
        {
            return false;
        }

        var query = "delete from Categories where CategoryId = @Id";
        connectionManager.GetConnection().Execute(query, category);
        return true;
    }

    public bool Update(CategoryDTO category)
    {
        var exist = CheckIfExistByName(category.Name, category.Id);
        if (exist)
        {
            return false;
        }

        var query = @"update Categories set CategoryName = @Name, Description = @Description where CategoryId = @Id";
        connectionManager.GetConnection().Execute(query, category);
        return true;
    }

    private bool CheckIfExistByName(string name, int id)
    {
        var countQuery = "select count(0) from Categories where CategoryName = @Name and CategoryId <> @Id";
        var count = connectionManager.GetConnection().ExecuteScalar<int>(countQuery, new { Name = name, Id = id });

        if (count > 0)
        {
            return true;
        }
        return false;
    }
}
