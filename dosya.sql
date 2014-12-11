create table PuanDurumu(
	ID int not null identity(1,1) primary key,
	Puan int,
	Tarih datetime default CURRENT_TIMESTAMP,
	Tip nvarchar(10),
	Isim nvarchar(50)
);