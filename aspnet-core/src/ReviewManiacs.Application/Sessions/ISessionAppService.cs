﻿using System.Threading.Tasks;
using Abp.Application.Services;
using ReviewManiacs.Sessions.Dto;

namespace ReviewManiacs.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
