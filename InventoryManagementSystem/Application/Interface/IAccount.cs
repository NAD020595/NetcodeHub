﻿using Application.DTO.Request.Identity;
using Application.DTO.Response;
using Application.DTO.Response.Identity;

namespace Application.Interface
{
    internal interface IAccount
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimAsync();
        Task SetUpAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
        //Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        //Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();

    }
}
