using com.Library.Web.Controllers.ViewModel;
using com.Library.Web.Models;

namespace com.Library.Web.Services
{
    public interface IUserService : ICommonService<UserModel>
    {
        ServiceResult<SignupViewModel> Signup(SignupViewModel model);
        ServiceResult<LoginViewModel> Login(LoginViewModel model);
    }
}
