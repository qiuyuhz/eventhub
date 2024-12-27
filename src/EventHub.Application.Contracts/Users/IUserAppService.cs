using System.Collections.Generic;
using System.Threading.Tasks;
using EventHub.Members;
using Volo.Abp.Application.Services;

namespace EventHub.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task<UserDto> FindByUserNameAsync(string username);
        /// <summary>
        /// 模糊查找
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        Task<List<UserInListDto>> GetListByUserName(string username);
    }
}
