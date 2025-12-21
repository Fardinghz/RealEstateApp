CREATE DATABASE IF NOT EXISTS REALESTATE ;

USE REALESTATE ;

CREATE TABLE IF NOT EXISTS PROPERTY (
       price VARCHAR(20) NOT NULL ,
       OwnerName varchar(25) not null ,
       phoneNumber varchar(11) not null 
);

CREATE TABLE IF NOT EXISTS VILLA (
	   LandMetrage INT NOT NULL,
       BuildingMetrage INT NOT NULL ,
       BuildYear INT NOT NULL ,
       RoomNumber INT NOT NULL ,
       Address VARCHAR(100) NOT NULL ,
       Parking bool NOT NULL 
);

CREATE TABLE IF NOT EXISTS APARTMENT (
       Metrage INT NOT NULL ,
       BuildYear INT NOT NULL ,
       Tabaghe INT NOT NULL , 
       BuildingName varchar(15) ,
       Address VARCHAR(100) NOT NULL , 
       RoomNumber INT NOT NULL , 
       Parking BOOL NOT NULL ,
       Anbary BOOL NOT NULL , 
       Asansor BOOL NOT NULL 
);
       
       
       
       
       
       
       
       
       
       
       
       
       