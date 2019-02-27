CREATE TABLE [dbo].[Uzytkownik](
	[Loggin] [nchar](50) NOT NULL,
	[ID] [bigint] NOT NULL,
	[Imie] [nchar](50) NOT NULL,
	[Nazwisko] [nchar](50) NOT NULL,
	[Haslo] [nchar](50) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[DataRejestracji] [nchar](50) NOT NULL,
	[NrTelefonu] [nchar](50) NOT NULL,
	[IDAdresu] [bigint] NOT NULL
) ON [PRIMARY]
