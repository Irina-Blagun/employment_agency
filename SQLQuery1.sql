use [employment.agency]

SELECT * FROM employer
SELECT * FROM vacancy
SELECT * FROM employer_vacancy
SELECT * FROM seeker
SELECT * FROM resume


DELETE FROM employer WHERE id_employer = 37
DELETE FROM vacancy WHERE id_vacancy = 1016

DELETE FROM employer WHERE id_employer = 36

INSERT INTO employer_vacancy(id_employer, id_vacancy) VALUES(36, 8)

/* Удаление всех вакансий работодателя */
CREATE TRIGGER [DELETE_EMPLOYER]
	ON dbo.employer
	INSTEAD OF DELETE
AS
BEGIN
	SET NOCOUNT ON;


	DELETE dbo.vacancy
	FROM deleted
	WHERE vacancy.id_vacancy in (SELECT id_vacancy FROM employer_vacancy WHERE employer_vacancy.id_employer = deleted.id_employer)
	DELETE dbo.employer
	FROM deleted
	WHERE employer.id_employer = deleted.id_employer

END
GO




create table seeker
 (
  id_seeker int not null identity(1,1) primary key,
  sr_name varchar(50) not null,
  sr_phone varchar(30) not null,
  sr_info varchar(300) not null,
 )


 drop table resume


 create table resume 
 (
  id_resume int not null identity(1,1) primary key,
  id_seeker int not null foreign key references seeker(id_seeker),
  re_office varchar(100) not null,
  re_age int not null,
  re_sex varchar(10),
  re_experience bit not null,
  re_education varchar(200) not null,
  re_creation_date date null,
  re_min_salary int not null,
  re_social_package bit not null, 
  re_employment varchar(20) not null, 
  re_schedule varchar(20) not null, 
  re_activity varchar(30) not null,
  re_education_place varchar(100) null,
  re_workplace varchar (100) null
 )