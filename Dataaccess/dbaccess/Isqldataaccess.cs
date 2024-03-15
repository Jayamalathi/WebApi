namespace dataaccess.dbaccess
{
    public interface Isqldataaccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionId = "Default") where U : class;
        Task<IEnumerable<T1>> LoadData<T1, T2>(string storedProcedure);
        Task Savedata<T>(string storedProcedure, T parameters, string connectionId = "Default");
    }
}