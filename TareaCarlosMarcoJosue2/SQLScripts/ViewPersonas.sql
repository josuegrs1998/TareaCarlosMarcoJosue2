use AdventureWorks2016;

	create view Person.VistaPersonas as 
	SELECT  ISNULL(P.Title, 'Dr.') as Titulo,  ''+ P.FirstName + ' ' +P.MiddleName + ' ' + P.LastName as NombreCompleto,  E.EmailAddress as Correo, C.PhoneNumber, DF.City, DF.AddressLine1, sp.Name
	FROM Person.Person as P
	inner join Person.EmailAddress as E on (P.BusinessEntityID = E.BusinessEntityID)
	inner join Person.PersonPhone as C on (P.BusinessEntityID  = C.BusinessEntityID)
	inner join Person.BusinessEntityAddress as D on (P.BusinessEntityID = D.BusinessEntityID)
	inner join Person.Address as DF on (D.AddressID = DF.AddressID)
	inner join Person.StateProvince as SP on (DF.StateProvinceID = SP.StateProvinceID)
	where P.MiddleName is not null