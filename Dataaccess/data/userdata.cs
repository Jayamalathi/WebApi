using dataaccess.dbaccess;
using dataaccess.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace dataaccess.data;

public class userdata : Iuserdata
{
    private readonly Isqldataaccess _db;
    public userdata(Isqldataaccess db)
    {
        _db = db;
    }
    public Task<IEnumerable<usermodel>> Getusers() =>
        _db.LoadData<usermodel, dynamic>(storedProcedure: "dbo.spuser_Getall", new { });

    public async Task<IEnumerable<usermodel>> Getuser(int id)
    {
        var results = await _db.LoadData<usermodel, dynamic>(
            storedProcedure: "dbo.spuser_Get",
            new { Id = id });
        return (IEnumerable<usermodel>)results.FirstOrDefault();
    }

    public Task InsertUser(usermodel user) =>
        _db.Savedata(storedProcedure: "dbo.spuser_update", user);

    public Task DeleteUser(int id) =>
        _db.Savedata(storedProcedure: "dbo.spuser_delete", new { Id = id });

    public Task UpdateUser(usermodel user)
    {
        throw new NotImplementedException();
    }
}
