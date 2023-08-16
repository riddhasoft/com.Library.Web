using com.Library.Web.Data;
using com.Library.Web.Models;

namespace com.Library.Web.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        private readonly ILogger<BookService> _logger;

        public BookService(AppDbContext context, ILogger<BookService> logger)
        {
            _context = context;
            _logger = logger;
        }
        public ServiceResult<int> Add(BookModel model)
        {
            _context.Book.Add(model);
            int result = _context.SaveChanges();
            return new ServiceResult<int>
            {
                Data = result,
                Status = ResultStatus.success,
                Message = "Book Created Successfully...!!!"
            };
        }

        public List<BookIdentificationModel> AddNewBook(BookModel book, int NoOfBook)
        {
            int maxSN = _context.BookIdentification.Max(x => x.Id);
            string sn = "";

            for (int i = 0; i < NoOfBook; i++)
            {
                sn = (maxSN + 1) + "";
                BookIdentificationModel bookIdentificationModel = new BookIdentificationModel()
                {
                    BookId = book.Id,
                    SN = sn,
                    Status = BookStatus.InLibrary
                };
                _context.BookIdentification.Add(bookIdentificationModel);

            }


            throw new NotImplementedException();
        }

        public ServiceResult<int> Delete(int id)
        {
            _context.Book.Remove(_context.Book.Find(id));
            int result = _context.SaveChanges();
            return new ServiceResult<int>
            {
                Data = result,
                Status = ResultStatus.success,
                Message = "Book Created Successfully...!!!"
            };
        }

        public ServiceResult<BookModel> GetById(int id)
        {
            BookModel model = _context.Book.Find(id);

            bool condition = model is null;
            if (condition)
            {
                return new ServiceResult<BookModel>
                {
                    Data = model,
                    Status = ResultStatus.failure,
                    Message = "No Book Found...!!!"
                };
            }
            return new ServiceResult<BookModel>
            {
                Data = model,
                Status = ResultStatus.success,
                Message = "Book Created Successfully...!!!"
            };
        }

        public ServiceResult<List<BookModel>> List()
        {

            return new ServiceResult<List<BookModel>>
            {
                Data = _context.Book.ToList(),

            };
        }

        public ServiceResult<int> Update(BookModel model)
        {
            _context.Book.Update(model);
            int result = _context.SaveChanges();
            return new ServiceResult<int>
            {
                Data = result,
                Status = ResultStatus.success,
                Message = "Book Update Successfully...!!!"
            };
        }
    }
}
