

USE master
GO

--drops database if it exists
IF DB_ID('nat_parks_personal') IS NOT NULL
BEGIN
	DROP DATABASE nat_parks_personal;
END

CREATE DATABASE nat_parks_personal
GO

USE nat_parks_personal
GO

BEGIN TRANSACTION

Create table parks_list (
park_id int IDENTITY(1,1)NOT NULL PRIMARY KEY,
id varchar(100) NOT NULL,
park_url varchar(100) NOT NULL,
full_name varchar(100) NOT NULL,
park_code char(4) NOT NULL,
park_description varchar(1000) NOT NULL,
latitude varchar(50) NOT NULL,
longitude varchar(50) NOT NULL,
lat_long varchar(100),
states varchar(50) NOT NULL,
directions_info varchar(1000),
directions_url varchar(100),
weather_info varchar(1000),
park_name varchar(50) NOT NULL,
designation varchar(50) NOT NULL)

Create table activities (
activities_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
id varchar(100) NOT NULL,
activities_name varchar(100) NOT NULL)

create table parks_activities (
parkID int NOT NULL,
activitiesID int NOT NULL,
FOREIGN KEY (parkID) references parks_list(park_id),
FOREIGN KEY (activitiesID) references activities(activities_ID)
)


create table topics (
topic_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
id varchar(100) NOT NULL,
topic_name varchar(100) NOT NULL)

create table park_topics (
parkID int NOT NULL,
topicID int NOT NULL,
FOREIGN KEY (parkID) references parks_list(park_id),
FOREIGN KEY (topicID) references topics(topic_id)
)

create table addresses (
parkID int NOT NULL,
postal_code varchar(25) NOT NULL,
city varchar(50) NOT NULL,
state_code char(2) NOT NULL,
line1 varchar(50) NOT NULL,
address_type varchar(25) NOT NULL,
line2 varchar (50),
line3 varchar (50),
FOREIGN KEY (parkID) references parks_list(park_id)
)

create table phone_numbers (
parkID int NOT NULL,
phone_number varchar(15) NOT NULL,
phone_description varchar(50),
phone_type varchar(50),
extension varchar(20),
FOREIGN KEY (parkID) references parks_list(park_id)
)

create table emails (
parkID int NOT NULL,
email varchar(50) NOT NULL,
email_description varchar(50),
FOREIGN KEY (parkID) references parks_list(park_id)
)

create table entrance_fees (
parkID int NOT NULL,
cost smallmoney NOT NULL,
fee_description varchar(100),
fee_title varchar(25),
FOREIGN KEY (parkID) references parks_list(park_id)
)

create table entrance_passes (
parkID int NOT NULL,
cost smallmoney NOT NULL,
pass_description varchar(100),
pass_title varchar(25),
FOREIGN KEY (parkID) references parks_list(park_id)
)

create table images (
parkID int NOT NULL,
credit varchar(50) NOT NULL,
title varchar(100) NOT NULL,
alt_text varchar(50) NOT NULL,
caption varchar(1000) NOT NULL,
image_url varchar(50) NOT NULL,
FOREIGN KEY (parkID) references parks_list(park_id)
)

create table operating_hours (
hours_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
parkID int NOT NULL,
park_name varchar(50),
hours_description varchar(100) NOT NULL,
FOREIGN KEY (parkID) references parks_list(park_id)
)

create table standard_hours (
hoursID int NOT NULL,
monday varchar(50) NOT NULL,
tuesday varchar(50) NOT NULL,
wednesday varchar(50) NOT NULL,
thursday varchar(50) NOT NULL,
friday varchar(50) NOT NULL,
saturday varchar(50) NOT NULL,
sunday varchar(50) NOT NULL,
FOREIGN KEY (hoursID) references operating_hours(hours_id)
)

create table exceptions (
exception_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
hoursID int NOT NULL,
exception_start_date date NOT NULL,
exception_end_date date NOT NULL,
exception_name varchar(50),
FOREIGN KEY (hoursID) references operating_hours(hours_id)
)

create table exceptions_hours (
exceptionID int NOT NULL,
monday varchar(50) NOT NULL,
tuesday varchar(50) NOT NULL,
wednesday varchar(50) NOT NULL,
thursday varchar(50) NOT NULL,
friday varchar(50) NOT NULL,
saturday varchar(50) NOT NULL,
sunday varchar(50) NOT NULL,
FOREIGN KEY (exceptionID) references exceptions(exception_id)
)


select * from parks_list