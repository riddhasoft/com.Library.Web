using com.Library.Web.Models;

namespace com.Library.Web.Services
{
    public interface IBookService : ICommonService<BookModel>
    {

        List<BookIdentificationModel> AddNewBook(BookModel book, int NoOfBook);

    }
}
