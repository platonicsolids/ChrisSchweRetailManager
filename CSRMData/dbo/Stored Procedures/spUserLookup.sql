CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
AS
begin
set nocount on;

	SELECT FirstName, LastName, EmailAdress, CreateDate
	from dbo.Users
	where Id = @Id;
end
