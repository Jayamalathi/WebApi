CREATE PROCEDURE [dbo].[spuser_insert]
    @Firstname nvarchar(50),
	@lastname nvarchar(50)
	
AS
begin 
   insert into dbo.[user] (Firstname, lastname)
   values (@Firstname ,@lastname);
end
