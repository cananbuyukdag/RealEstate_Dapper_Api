using Dapper;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Dtos.UserDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.UserRepositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
        public async Task<GetUserByProductIdDto> GetUserByProductId(int id)
        {
            string query = "Select * From Users Where UserID=@UserID";
            var parameters = new DynamicParameters();
            parameters.Add("@UserID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetUserByProductIdDto>(query, parameters);
                return values;
            }
        }
    }
}
