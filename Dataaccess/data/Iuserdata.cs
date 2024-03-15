using dataaccess.models;

namespace dataaccess.data
{
    public interface Iuserdata
    {
        Task DeleteUser(int id);
        Task<IEnumerable<usermodel>> Getuser(int id);
        Task<IEnumerable<usermodel>> Getusers();
        Task InsertUser(usermodel user);

        Task UpdateUser(usermodel user);


    }
}