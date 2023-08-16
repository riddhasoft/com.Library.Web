using com.Library.Web.Data;
using com.Library.Web.Models;

namespace com.Library.Web.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<StudentService> _logger;

        public UserService(AppDbContext context, ILogger<StudentService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public ServiceResult<int> Add(UserModel model)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<UserModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<List<UserModel>> List()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<int> Update(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
