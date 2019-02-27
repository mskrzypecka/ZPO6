CREATE TABLE [dbo].[Adres](
	[ID] [bigint] NOT NULL,
	[Miasto] [nchar](30) NOT NULL,
	[Ulica] [nchar](30) NOT NULL,
	[Numer] [int] NOT NULL,
	[KodPocztowy] [nchar](6) NOT NULL
) ON [PRIMARY]
