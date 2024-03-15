CREATE PROCEDURE [dbo].[spuser_update]
	@Id int,
	@Firstname nvarchar(50),
	@lastname nvarchar(50)
AS
begin
   update dbo.[user] set Firstname = @Firstname,lastname=@lastname
   where Id =@id;
end
	
