using Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.User
{
    public interface IUserService
    {
        Task<List<UserEntity>> GetAllUsersAsync();
        Task<UserEntity?> GetUserByIdAsync(int id);

        
        Task<bool> AddUserAsync(UserEntity user);

       
        Task<bool> DeleteUserAsync(int id);
    }
}
}
