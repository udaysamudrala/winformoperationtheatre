CREATE DATABASE OPERATION_THEATRE
ON
 primary
(
NAME=OPTDATA,
FILENAME='C:\OPERATIONTHEATER-CASESTUDY\DBfiles\OPTDATA.MDF',
SIZE=5MB,
FILEGROWTH=1MB,
MAXSIZE=10MB
)
LOG ON 
(
NAME=OPTLOG,
FILENAME='C:\OPERATIONTHEATER-CASESTUDY\DBfiles\OPTLOG.LDF',
SIZE=5MB,
MAXSIZE=10MB,
FILEGROWTH=1MB
)

USE OPERATION_THEATRE


CREATE TABLE PATIENT_DETAILS
(
PATIENT_ID int PRIMARY KEY Identity(100,1),
PATIENT_NAME varchar(50) NOT NULL,
GENDER varchar(8) NOT NULL,
AGE int NOT NULL,
ADDRESS varchar(50) NOT NULL,
PHONE_NO varchar(50),
ADMIT_DATE datetime NOT NULL,
DISCHARGE_DATE datetime NULL,
WARD_TYPE varchar(50) NOT NULL,
BED_NO int NOT NULL,
NO_OF_DAYS int NOT NULL,
DISEASE_TYPE varchar(50) NOT NULL,
DOCTOR_ID int UNIQUE NOT NULL,
DOCTOR_NAME varchar(50) NOT NULL,
OPERATION_DATE datetime  NULL,
OPERATIONTHEATRE_ID int NULL,
)


DROP TABLE PATIENT_DETAILS


----INSERTING VALUES.......
INSERT INTO PATIENT_DETAILS VALUES('RAVIMADHOGARHIA','M',22,'MALAKPET','9704175531','10-03-2011',NULL,'AC',4,7,'HEARTSTROKE',5,'DR.UDAYKIRAN','10-05-2011',NULL)



SELECT * FROM PATIENT_DETAILS

CREATE TABLE STAFF_DETAILS
(
STAFF_ID int PRIMARY KEY IDENTITY,
STAFF_NAME varchar(50) NOT NULL,
PHONE_NO varchar(50) NOT NULL,
DEPARTMENT_NAME varchar(50) NOT NULL,
STAFF_DESIGNATION varchar(50) NOT NULL,
SHIFT_TIMINGS varchar(50) NOT NULL,
JOINING_DATE datetime NOT NULL,
SALARY SMALLMONEY NOT NULL,
RESOURCE_ID int FOREIGN KEY REFERENCES resources(resource_id)
)
Alter table STAFF_DETAILS drop column STAFF_DESIGNATION 
Alter table STAFF_DETAILS add GENDER varchar(20)
Alter table STAFF_DETAILS add AGE int 

alter table STAFF_DETAILS add constraint foreign key(resource_id) references resources(resource_id)



DROP TABLE STAFF_DETAILS

select * from STAFF_DETAILS

-- enter into staff details 

INSERT INTO STAFF_DETAILS VALUES('ANUPAL','9908993236','CONSULTANT','PHYSICIAN','9AM TO 1 PM',10-10-2010,20000)



--DOCTOR TABLE CREATION




CREATE TABLE DOCTOR_DETAILS
(
DOC_ID int PRIMARY KEY,
DOC_NAME varchar(50) NOT NULL,
DOC_SPECIALIZATION varchar(50) NOT NULL,
DOC_CONTACT_NO varchar(50) NOT NULL,
DOC_JOIN_DATE datetime NOT NULL,
DOC_SALARY smallmoney NOT NULL,
DOC_AVAILABLITY varchar(20) NOT NULL,
DOC_EXPERIENCE varchar(20) NOT NULL
)

DROP TABLE DOCTOR_DETAILS



select * from DOCTOR_DETAILS
INSERT INTO DOCTOR_DETAILS VALUES('5','DR.UDAYKIRAN','HEARTSURGEON','9701444743','10-15-2006','75000','YES','5 YEARS')


select * from 

CREATE TABLE PRE_OPERATION
(
PATIENT_ID int FOREIGN KEY REFERENCES PATIENT_DETAILS(PATIENT_ID)NOT NULL,
BLOOD_PRESSURE varchar(20) NULL,
CHECK_BLOOD_GROUP varchar(20) NOT NULL,
SUGAR_LEVEL_CHECKUP varchar(20),
PRE_ANESTHETIC_CHECK varchar(20),
PULSE_RATE varchar(20),
)

DROP TABLE PRE_OPERATION
INSERT INTO PRE_OPERATION VALUES (100,'180/50','B+','1200points','HIGHRISK','70')


--after operation
USE OPERATION_THEATRE
CREATE TABLE POST_OPERATION
(
PATIENT_ID int FOREIGN KEY REFERENCES PATIENT_DETAILS(PATIENT_ID),
OPERATION_STATUS varchar(20),
INFECTION_STATUS varchar(20),
BLOOD_PRESSURE varchar(20) NULL,
CHECK_BLOOD_GROUP varchar(20) NOT NULL,
SUGAR_LEVEL_CHECKUP varchar(20),
POST_ANESTHETIC_CHECK varchar(20),
)

INSERT INTO POST_OPERATION VALUES (100,'URGENT','NIL','NORMAL 120/80','B+','540points','NORMALSTATE')


DROP TABLE POST_OPERATION


CREATE TABLE BILLING_DETAILS 
(

PATIENT_ID int FOREIGN KEY REFERENCES PATIENT_DETAILS(PATIENT_ID) NOT NULL,
BLOOD_UNITS_USED int ,
MEDICINE_CHARGES smallmoney,
DOCTOR_FEE smallmoney,
ECG_CHARGES smallmoney,
BLOOD_TEST_CHARGES smallmoney,
XRAY_CHARGES smallmoney,
BODY_CHECKUP_CHARGES smallmoney,
MISCELLANEOUS_CHARGES smallmoney,
NO_OF_DAYS_TREATED int NOT NULL,

)

ALTER table BILLING_DETAILS add Total_Amount smallMoney;
INSERT INTO BILLING_DETAILS VALUES(100,200,5000,1000,3000,200,300,500,500,20,10500)


DROP TABLE BILLING_DETAILS 

select * from BILLING_DETAILS;


create table Administrator
(LoginID int primary key,password varchar(20) Not null)
insert into Administrator values('123','123')
Drop table Administrator



create table LoginDetails
(LoginID int primary key,password varchar(20) not null)
insert into LoginDetails values('123','ravi')
insert into LoginDetails values('345','ravi')
insert into LoginDetails values('678','ravi')




CREATE TABLE PATIENT_REGISTRATION
(
PATIENT_ID int PRIMARY KEY Identity(100,1),
PATIENT_FIRSTNAME varchar(50) NOT NULL,
PATIENT_LASTNAME varchar(50) NOT NULL,
GENDER varchar(8) NOT NULL,
AGE int NOT NULL,
ADDRESS varchar(50) NOT NULL,
PHONE_NO varchar(50),
USER_NAME varchar(50),
PASSWORD varchar(50),
EMAIL_ID varchar(20)
)
alter table PATIENT_REGISTRATION drop column USER_NAME 
alter table PATIENT_REGISTRATION drop column  PASSWORD
select * from PATIENT_REGISTRATION
insert into PATIENT_REGISTRATION values('Ravi','s','male',35,'padalkur','9703675389','ravitej','ravi','raviteja@gmail.com')



create table surgeons 
( surgeon_id int primary key,
  surgeon_name varchar(20) not null,specialisation varchar(20) not null)
insert into  surgeons values('100','Ranganath','cardiologist')
insert into  surgeons values('200','Ramadevi','nephrologist')



create table anesthetists
(
anesthetists_id varchar(20) primary key,anesthetists_name varchar(20)not null)

insert into anesthetists values('a1','hgdhj')
insert into anesthetists values('a2','ajdgkkau')

SELECT * FROM Patient_Registration

create table NursingStaff(
Nurse_id varchar(20) primary key,Nurse_name char(10))
insert into NursingStaff values('N001','pratyusha')
insert into NursingStaff values('N002','Anusha')




select * from resources
--Alter table resources add resource_id varchar(20) Primary key identi
--Alter table resources drop resource_id varchar(20) primary key




drop table LogiDetails