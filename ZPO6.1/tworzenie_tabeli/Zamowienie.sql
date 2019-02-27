CREATE TABLE [dbo].[Zamowienie](
	[ID] [bigint] NOT NULL,
	[Nazwa] [nchar](60) NOT NULL,
	[DataZamowienia] [datetime] NOT NULL,
	[IDKlienta] [bigint] NOT NULL
) ON [PRIMARY]
