﻿namespace RealEstate_Dapper_Api.Dtos.ProductDetailDtos
{
    public class GetProductImageByProductIdDto
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string ImageUrl { get; set; }

    }
}
