drop database ITC;	
	create database ITC;
		use ITC;
		create table Membre(
			Id int auto_increment,
			FirstName varchar(25) not null,
			LastName varchar(25)not null,
			dep varchar(30) not null,
			email varchar(30),
			Phone varchar(15),
			Teamname varchar(30),
			grad varchar(50) not null,
				constraint Membre_pk primary key (id)
		
			);



		
		create table Team(
		Teamname varchar(30) not null ,
		TeamleaderId int ,
			constraint TeamLeader foreign key (TeamleaderId ) references Membre(Id),
					constraint Team_pk primary key (Teamname)
		
			
			);

			alter table Membre 
			add constraint FK_membre foreign key (Teamname) references Team(Teamname);

     create table Event(
     		EventName varchar(30) not null,
     		EventChargeId int not null,
     		describetion varchar(150) not null,
     		constraint Event_fk foreign key (EventChargeId) references Membre(Id),
     		constraint Event_pk primary key (EventName)
     	);

    create table organ(
     		organId int not null,
     		Eventname varchar(30) not null,
     		job varchar(20),
     		constraint Organ_fk foreign key (organId) references Membre(Id),
     		
     		constraint Organ_fk2 foreign key (EventName) references Event(Eventname)
     	);




    

     describe Membre ;
     describe Team;
     describe Event;
     describe organ;
  




     	create table Skill (


     			IdSkill int auto_increment,
     			
     			 descrebtion varchar(150) not null,

     			constraint skill_PK primary key (IdSkill)
     			

     			 ) ;



     		
     create table Partenaire(
     		IdPartenaire int auto_increment,
     		 Firstname varchar(20) not null, 
     		Lastname varchar(20),
            Phone Varchar(15),
     		 email varchar(30),
     		constraint Partenaire_PK primary key (IdPartenaire)
     	);

     create table PartenaireSkill(

     				IdSkill int not null,
     				IdPartenaire int not null,
     				constraint PartenaireSkill_fk foreign key (IdSkill) references  Skill(IdSkill),

     				constraint PartenaireSkill_fk2 foreign key (IdPartenaire) references Partenaire(IdPartenaire) 


     	);
     create table SkillM(

     				IdSkillMembre int not null,
     				IdMembre int not null,
     		
     		constraint SkillM_Fk foreign key (IdSkillMembre) references Skill(Idskill),

     		constraint SkillM2_Fk foreign key (IdMembre) references Membre(Id)


     	);

     	create table EventPartenaire(
     		Eventname varchar(30) not null,
     		IdPartenaire int ,
     		constraint EventPartenaire_Fk foreign key (Eventname) references Event(Eventname),
     		constraint EventPartenaire_Fk2 foreign key (IdPartenaire) references Partenaire(IdPartenaire)

     		);


     create table Formation (
     	IdFormation int ,
     	formationName varchar(40) not null,
     	formationDescription varchar(150),
     	IdFormerMembre int,
     	IdFormerPartenaire int,
        temp date,
     	constraint Formation_PK primary key (IdFormation),
     	constraint Formation_fk foreign key (IdFormerMembre) references Membre(Id),
     	constraint Formation_fk2 foreign key (IdFormerPartenaire) references Partenaire(IdPartenaire)
     	);

     	

   describe skill;
describe Partenaire;
describe PartenaireSkill;
describe SkillM;
 describe EventPartenaire;
 describe Formation;