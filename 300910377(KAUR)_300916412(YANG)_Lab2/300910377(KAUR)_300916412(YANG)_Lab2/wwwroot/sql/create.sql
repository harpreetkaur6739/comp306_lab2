use moviedb;

create table users(
	userId int primary key identity(1,1),
	userName varchar(50) not null,
	password varchar(500) not null,
	role varchar(10)
);

create table userinfo(
  userId int primary key,
  firstName varchar(30) not null,
  lastName varchar(30),
  email varchar(50) not null,
  foreign key (userId) references users(userId)
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

create table association(
	associationId int primary key identity(1,1),
	userId int,
	videoId int,
	commentId int,
	foreign key(userId) references users(userId),
	foreign key(videoId) references movie(movieId),
	foreign key(commentId) references comment(commentId)
);