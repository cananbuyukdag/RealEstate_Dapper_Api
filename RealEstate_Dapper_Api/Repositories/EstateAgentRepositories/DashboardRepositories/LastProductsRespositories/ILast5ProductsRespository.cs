using RealEstate_Dapper_Api.Dtos.ProductDtos;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRespositories
{
    public interface ILast5ProductsRespository
    {
        Task<List<Result5LastProductWithCategoryDto>> GetLast5ProductsAsync(int id);
    }
}
