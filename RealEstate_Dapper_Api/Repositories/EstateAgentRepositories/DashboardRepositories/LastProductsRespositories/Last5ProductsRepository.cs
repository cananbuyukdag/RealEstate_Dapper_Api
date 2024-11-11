using Dapper;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRespositories
{
    public class Last5ProductsRepository : ILast5ProductsRespository
    {
        private readonly Context _context;
        public Last5ProductsRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<Result5LastProductWithCategoryDto>> GetLast5ProductsAsync(int id)
        {
            string query = "Select Top(5) ProductID, Title, Price, City, Type, District, ProductCategory, CreatedDate, CategoryName from Product inner join Category on Product.ProductCategory = Category.CategoryID Where EmployeeId=1 Order By Product.ProductID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Result5LastProductWithCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
