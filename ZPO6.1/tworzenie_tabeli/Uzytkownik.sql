CREATE TABLE [dbo].[Uzytkownik](
	[Login] [nchar](25) NOT NULL,
	[ID] [bigint] NOT NULL,
	[Imie] [nchar](15) NOT NULL,
	[Nazwisko] [nchar](20) NOT NULL,
	[Haslo] [nchar](15) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[DataRejestracji] [date] NOT NULL,
	[NrTelefonu] [nchar](9) NOT NULL
) ON [PRIMARY]
