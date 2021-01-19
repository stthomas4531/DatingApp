using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.DTOs;

namespace API.Interfaces
{
    public interface IUserRepository
    {
       void Update(AppUser user); 
       Task<bool> SaveAllAsync();
       Task<IEnumerable<AppUser>> GetUsersAsync();
       Task<AppUser> GetUserByIdAsync(int id);
       Task<AppUser> GetUserByUserNameAysnc(string username);
       Task<IEnumerable<MemberDto>> GetMembersAsync();
       Task<MemberDto> GetMemberAsync(string username);
    }
}