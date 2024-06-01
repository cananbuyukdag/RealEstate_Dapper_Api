namespace RealEstate_Dapper_Api.Dtos.CategoryDtos
{
    public class GetByIDServiceDto
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
