using Dapper;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async void DealOfTheDayChangeStatusTrue(int id)
        {
            string query = "Update Product set DealOfTheDay=1 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
        public async void DealOfTheDayChangeStatusFalse(int id)
        {
            string query = "Update Product set DealOfTheDay=0 where ProductID=@productID";
            var parameters = new DynamicParameters();
            parameters.Add("@productID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * from Product";
            using (var connection = _context.CreateConnection()) { 
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductID, Title, Price, City,District, DealOfTheDay,CategoryName, CoverImage, Type, Address from Product inner join Category on Product.ProductCategory=Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<Result5LastProductWithCategoryDto>> GetLast5ProductsAsync()
        {
            string query = "Select Top(5) ProductID, Title, Price, City, Type, District, ProductCategory, CreatedDate, CategoryName from Product inner join Category on Product.ProductCategory = Category.CategoryID Order By Product.ProductID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Result5LastProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsync(int id)
        {
            string query = "Select ProductID, Title, Price, City,District, DealOfTheDay,CategoryName, CoverImage, Type, Address from Product inner join Category on Product.ProductCategory=Category.CategoryID where EmployeeID=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdvertListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
