CREATE PROCEDURE [dbo].[SpRetrieveContacts]
AS
	SELECT firstName, lastName, address, city, state, zip, phoneNumber, email FROM Contacts;
RETURN 0