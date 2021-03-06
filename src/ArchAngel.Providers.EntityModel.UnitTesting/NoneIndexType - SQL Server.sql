CREATE TABLE [Table1] (
	[Column1] int NOT NULL,
	[Column2] nvarchar(100) NULL,
	[Column3] datetime NOT NULL   
);

ALTER TABLE [Table1] ADD PRIMARY KEY ([Column1]);

CREATE UNIQUE INDEX [UQ__Table1] ON [Table1] ([Column1] Asc);

CREATE INDEX [UQ_AllColumns] ON [Table1] ([Column1] Asc,[Column2] Asc,[Column3] Asc);