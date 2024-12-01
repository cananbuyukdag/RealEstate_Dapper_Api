using RealEstate_Dapper_Api.Dtos.UserDtos;

namespace RealEstate_Dapper_Api.Repositories.UserRepositories
{
    public interface IUserRepository
    {
        Task<GetUserByProductIdDto> GetUserByProductId(int id);
    }
}
