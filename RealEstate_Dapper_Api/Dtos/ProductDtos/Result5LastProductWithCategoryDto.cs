﻿namespace RealEstate_Dapper_Api.Dtos.ProductDtos
{
    public class Result5LastProductWithCategoryDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
        public string CoverImage { get; set; }
        public string type { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CategoryName { get; set; }
    }
}
