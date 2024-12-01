namespace RealEstate_Dapper_Api.Dtos.UserDtos
{
    public class GetUserByProductIdDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImageUrl { get; set; }
    }
}
