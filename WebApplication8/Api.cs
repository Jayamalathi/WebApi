using dataaccess.data;
using dataaccess.models;

namespace WebApplication8
{
    public static class Api
    {
        private static object data;

        public static void ConfigureApi(this WebApplication app)
        {
            app.MapGet(pattern: "/Users", Getusers);
            app.MapGet(pattern: "/users/{id}", Getuser);
            app.MapPost(pattern: "/users", Insertuser);
            app.MapPut(pattern: "/users", Updateuser);
            app.MapDelete(pattern: "/users", Deleteuser);

        }

       

        private static async Task<IResult> Getusers(Iuserdata data)
        {
            try
            {
                return Results.Ok(await data.Getusers());
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> Getuser(int id, Iuserdata data)
        {
            try
            {
                var results = await data.Getusers();
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> Insertuser(usermodel user, Iuserdata data)
        {
            try
            {
                await data.InsertUser(user);
                return Results.Ok();
            }
            catch(Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> Updateuser(usermodel user,Iuserdata data)
        {
            try
            {
                await data.UpdateUser(user);
                return Results.Ok();
               
            }
            catch(Exception ex)
            {
                return Results.Problem();
            }
        } 
        private static async Task<IResult> Deleteuser(int id, Iuserdata data)
        {
            try
            {
                await data.DeleteUser(id);
                return Results.Ok();
            }
            catch(Exception ex)
            {
                return Results.Problem();
            }
        }

        
    }
}
