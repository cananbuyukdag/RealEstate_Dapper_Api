using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByTrue(int id);
        Task<List<ResultProductAdvertListWithCategoryByEmployeeDto>> GetProductAdvertListByEmployeeAsyncByFalse(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        void DealOfTheDayChangeStatusTrue (int id);
        void DealOfTheDayChangeStatusFalse (int id);
        Task<List<Result5LastProductWithCategoryDto>> GetLast5ProductsAsync();
        Task CreateProduct(CreateProductDto createProductDto);
    }
}
