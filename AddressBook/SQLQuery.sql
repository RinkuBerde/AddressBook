create database Address_Book1

create table Contacts(
firstName varchar(200) not null,
lastName varchar(200) not null,
address varchar(255) not null,
city varchar(255),
state varchar(255),
zip int,
phoneNumber bigint,
email varchar(200) not null
)

insert into  Contacts
values('rinku', 'berde', '54 backstreet', 'NY', 'America', 123654, 09876557843, 'rinku@email.com'),
('gitesh', 'kumar', '12 SM nagar', 'Mysore', 'Karnataka', 100004, 09876554322, 'gitesh@email.com'),
('terisa', 'sharma', '3 AB nagar', 'Noida', 'UP', 543201, 09876552321, 'terisa@email.com'),
('harsha', 'yadav', '84 MJ nagar', 'Chennai', 'Tamil Nadu', 129123, 09876554367, 'harsha@email.com')

select * from Contacts
