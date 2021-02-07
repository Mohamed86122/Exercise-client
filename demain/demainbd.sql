create database GTR

create table Client
(
IdClient int primary key, 
NomClient varchar(15), 
AdresseClient varchar(15), 
TelClient varchar(15)
)

create table Réservation
(
CodeReservation int primary Key,
#IdClient int foreign key references Client(IdClient),
daate date,
PensionComplete varchar(15)

)
create table Sejour 
(
NumSejour int primary Key identity(0,1), 
#CodeReservation int foreign key references Réservation(CodeReservation), 
DateSejour date, 
TypeSejour varchar(15), 
DureeSejour int
)


 Create table ReservationAnnulee 
 (
 #CodeReservation int foreign key references Réservation (CodeReservation), 
 #IdClient int foreign key references Client(IdClient), 
 constraint C1 primary key  (#CodeReservation,#IdClient),
 DateAnnulation date
 )

 select * 
 from Client

 select *
 from Réservation