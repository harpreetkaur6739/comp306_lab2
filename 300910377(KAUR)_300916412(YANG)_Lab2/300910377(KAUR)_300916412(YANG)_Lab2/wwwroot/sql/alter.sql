alter table movie add fileS3Name varchar(200);

alter table comment add userId int foreign key(userId) references users(userId);