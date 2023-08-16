using com.Library.Web.Data;
using com.Library.Web.Models;

namespace com.Library.Web.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<StudentService> _logger;

        public StudentService(AppDbContext context, ILogger<StudentService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public ServiceResult<int> Add(StudentModel model)
        {
            _context.Student.Add(model);
            int result = _context.SaveChanges();


            ServiceResult<int> serviceResult = new ServiceResult<int>();
            serviceResult.Data = result;
            serviceResult.Message = "Student Added Successfully...!!!";
            serviceResult.Status = ResultStatus.success;

            return serviceResult;
        }

        public ServiceResult<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<StudentModel> GetById(int id)
        {
            StudentModel model = _context.Student.Find(id);
            return new ServiceResult<StudentModel>()
            {
                Data = model,
                Status = ResultStatus.success

            };
        }

        public ServiceResult<List<StudentModel>> List()
        {
            throw new NotImplementedException();
        }

        public ServiceResult<int> Update(StudentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
