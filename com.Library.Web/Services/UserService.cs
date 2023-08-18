using com.Library.Web.Controllers.ViewModel;
using com.Library.Web.Data;
using com.Library.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace com.Library.Web.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly AppDbContext _context;
        private readonly ILogger<StudentService> _logger;

        public UserService(AppDbContext context, ILogger<StudentService> logger, IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
            _context = context;
            _logger = logger;
        }

        public ServiceResult<int> Add(UserModel model)
        {
            _context.Add(model);
            int result = _context.SaveChanges();
            return new ServiceResult<int>()
            {
                Data = result,
                Status = ResultStatus.success,
                Message = "User Added..."
            };
        }

        public ServiceResult<int> Delete(int id)
        {
            _context.User.Remove(_context.User.Find(id));
            int result = _context.SaveChanges();
            return new ServiceResult<int>()
            {
                Data = result,
                Status = ResultStatus.success,
                Message = "User Removed..."
            };
        }

        public ServiceResult<UserModel> GetById(int id)
        {
            return new ServiceResult<UserModel> { Data = _context.User.Find(id) };
        }

        public ServiceResult<List<UserModel>> List()
        {
            return new ServiceResult<List<UserModel>> { Data = _context.User.ToList() };
        }

        public ServiceResult<LoginViewModel> Login(LoginViewModel model)
        {
            var result = _context.User.Where(x => x.UserName == model.Username && x.Password == model.Password).FirstOrDefault();
            if (result != null)
            {
                //add identity information 
                addingClaimIdentity(result);
                //return success
                return new ServiceResult<LoginViewModel>
                {

                    Data = model
                    ,
                    Status = ResultStatus.success
                };

            }

        }
        private void addingClaimIdentity(UserModel user)
        {
            //list of claims
            var userClaims = new List<Claim>()
                {
                    new Claim("UserName", user.UserName),
                    new Claim("UserId",user.Id.ToString()),
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim(ClaimTypes.Role,"admin")
                 };

            //create a identity claims
            var claimsIdentity = new ClaimsIdentity(
            userClaims, CookieAuthenticationDefaults.AuthenticationScheme);


            //httcontext , current user is authentic user
            //sing in user to httpcontext
            _httpContext.HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(claimsIdentity)
            );
        }
        public ServiceResult<SignupViewModel> Signup(SignupViewModel model)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<int> Update(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
