CREATE PROCEDURE [dbo].[spuser_Getall]
	
AS
begin 
  select Id,Firstname, lastname from dbo.[user]; 
end
