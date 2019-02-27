CREATE TABLE [dbo].[Zamowienie](
	[ID] [bigint] NOT NULL,
	[Nazwa] [nchar](60) NOT NULL,
	[DataZamowienia] [nchar](60) NOT NULL,
	[IDKlienta] [bigint] NOT NULL,
	[IDDania] [bigint] NOT NULL
) ON [PRIMARY]
