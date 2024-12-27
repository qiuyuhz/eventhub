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
        /// ģ������
        /// </summary>
        /// <param name="username">�û���</param>
        /// <returns></returns>
        Task<List<UserInListDto>> GetListByUserName(string username);
    }
}
