CREATE PROCEDURE [dbo].[spuser_delete]
     @Id int
AS
begin
   delete from dbo.[user] where id =@id;
end
