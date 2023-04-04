using Application.DTO;
using Application.Mediator.Query;
using Application.Repository;
using Domain.Entities;
using Domain.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstraction.Service
{
    public interface IUserService
    {
        Task<ResultOfAction<UserDTO>> GetUserInfoAsync(GetUserInfoQuery query);
    }
}
