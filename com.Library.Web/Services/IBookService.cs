using com.Library.Web.Models;

namespace com.Library.Web.Services
{
    public interface IBookService : ICommonService<BookModel>
    {

        List<BookIdentificationModel> AddNewBook(BookModel book, int NoOfBook);

        BookInOutHistoryModel IssueBook(BookInOutHistoryModel model);
        BookInOutHistoryModel ReturnBook(BookInOutHistoryModel model);
        BookInOutHistoryModel RenewBook(BookInOutHistoryModel model);
        List<BookInOutHistoryModel> GetBookHistory(int Id);
    }
}
