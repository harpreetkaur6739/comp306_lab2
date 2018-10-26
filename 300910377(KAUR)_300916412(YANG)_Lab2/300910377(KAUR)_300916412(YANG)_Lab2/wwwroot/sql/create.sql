use moviedb;

create table users(
	userId int primary key identity(1,1),
	userName varchar(50) not null,
	password varchar(500) not null,
	role varchar(10)
);

create table movie(
	movieId int primary key identity(1,1),
	movieName varchar(100) not null,
	fileName varchar(100) not null,
	description varchar(1000)
);

create table comment(
	commentId int primary key identity(1,1),
	content varchar(1000),
	rating int
);

create table usermovie(
	id int primary key identity(1,1),
	userId int,
	movieId int,
	foreign key(userId) references users(userId),
	foreign key(movieId) references movie(movieId)
);

create table moviecomment(
	id int primary key identity(1,1),
	movieId int,
	commentId int,	
	foreign key(movieId) references movie(movieId),
	foreign key(commentId) references comment(commentId)
);