﻿using RealEstate_Dapper_Api.Dtos.WhoWeAreDtos;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreRepository
{
    public interface IWhoWeAreRepository
    {
        Task<List<ResultWhoWeAreDto>> GetAllWhoWeAreAsync();
        void CreateWhoWeAre(CreateWhoWeAreDto createWhoWeAreDto);
        void DeleteWhoAre(int id);
        void UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAreDto);
        Task<GetByIDWhoWeAreDto> GetByIDWhoWeAre(int id);
    }
}
