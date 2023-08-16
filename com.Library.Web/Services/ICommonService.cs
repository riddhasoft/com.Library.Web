namespace com.Library.Web.Services
{
    public interface ICommonService<T>
    {
        ServiceResult<List<T>> List();
        ServiceResult<int> Add(T model);
        ServiceResult<int> Update(T model);
        ServiceResult<int> Delete(int id);
        ServiceResult<T> GetById(int id);
    }
    public class ServiceResult<t>
    {
        public t Data { get; set; }
        public string Message { get; set; }
        public ResultStatus Status { get; set; }
    }
    public enum ResultStatus
    {
        success,
        failure,
        error
    }
}
