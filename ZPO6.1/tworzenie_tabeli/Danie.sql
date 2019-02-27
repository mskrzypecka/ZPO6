CREATE TABLE [dbo].[Danie](
	[ID] [bigint] NOT NULL,
	[Nazwa] [nchar](25) NOT NULL,
	[Cena] [money] NOT NULL,
	[MozliweZamowienia] [int] NOT NULL,
	[JestWege] [bit] NOT NULL
) ON [PRIMARY]
