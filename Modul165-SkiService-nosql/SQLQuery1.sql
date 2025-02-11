UPDATE Benutzer SET Rolle = 'Kunde' WHERE Rolle IS NULL;
SELECT TOP (1000) [Id]
      ,[Benutzername]
	  ,[Email]
      ,[Passwort]
      ,[Rolle]
  FROM [SkiServiceDB].[dbo].[Benutzer]

SELECT TOP (1000) [Id]
      ,[KundenName]
      ,[Email]
      ,[Telefon]
      ,[Prioritaet]
      ,[Dienstleistung]
	    ,[CreateDate]
	    ,[PickupDate]
      ,[Status]
  FROM [SkiServiceDB].[dbo].[Serviceauftraege]

 


