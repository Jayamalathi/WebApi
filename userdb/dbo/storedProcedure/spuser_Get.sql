CREATE PROCEDURE [dbo].[spuser_Get]
	@Id int
AS
begin 
  select Id,Firstname, lastname from dbo.[user]
  where Id=@Id;
end


