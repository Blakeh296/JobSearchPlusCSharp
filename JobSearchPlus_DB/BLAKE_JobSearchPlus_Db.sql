USE [master]
GO
		PRINT ''
BEGIN
	DROP DATABASE JobSearchPlus
END

		PRINT 'JobSearchPlus DROPPED'

CREATE DATABASE [JobSearchPlus]
 GO

		PRINT 'JobSearchPlus CREATED'

		PRINT ''

USE JobSearchPlus




GO

/****** Object:  [SOURCES]    DATABASE TABLE : ********** *:**:** PM ******DTPLAPTOP09*/
CREATE TABLE Sources (

			 SourceID bigint IDENTITY NOT NULL,
			 SourceName VARCHAR(75) NOT NULL,
			 SourceType VARCHAR(35) NULL,
			 SourceLink VARCHAR(255) NULL,
			 [Description] VARCHAR(255)
			 PRIMARY KEY (SourceID)
			 )

			 PRINT '1 Sources'



CREATE INDEX idx_SourceID on Sources (SourceID)


CREATE INDEX idx_SourceName on Sources (SourceName)


CREATE INDEX idx_SourceType on Sources (SourceType)

print '  idx_SourceID'
print '  idx_SourceName'
print '  idx_SourceType'


/****** Object:  [BUSINESS TYPES]    DATABASE TABLE : ******** *:**:** PM ******DTPLAPTOP09*/
CREATE TABLE BusinessTypes (

			 BusinessType VARCHAR(50) NOT NULL,
			 PRIMARY KEY (BusinessType)
			 
			 )

			 PRINT '2 BusinessTypes'

CREATE INDEX idx_BusinessType on BusinessTypes (BusinessType)

print '  idx_BusinessType'








/****** Object:  [COMPANIES]    DATABASE TABLE : ******** *:**:** PM ******DTPLAPTOP09*/
CREATE TABLE Companies (

			 CompanyID int Identity NOT NULL,
			 CompanyName VARCHAR(75) NOT NULL,
			 Address1 VARCHAR(75) NULL,
			 Address2 VARCHAR(75) NULL,
			 City VARCHAR(50) NULL,
			 [State] VARCHAR(2) NULL,
			 Zip VARCHAR(10) NULL,
			 Phone VARCHAR(14) NULL,
			 Fax VARCHAR(14) NULL,
			 Email VARCHAR(50) NULL,
			 Website VARCHAR(50) NULL,
			 [Description] VARCHAR(255) NULL,
			 BusinessType VARCHAR(50) FOREIGN KEY REFERENCES Businesstypes (Businesstype) NULL,
			 Agency BIT DEFAULT (0) NULL ,
			 PRIMARY KEY (CompanyID)
			 
			 )

			 PRINT '3 Companies' 

		
			


CREATE INDEX idx_CompanyID on Companies (CompanyID)


CREATE INDEX idx_CompanyName on Companies (CompanyName)


CREATE INDEX idx_PostalCode on Companies (Zip)


CREATE INDEX idx_City on Companies (City)


CREATE INDEX idx_State on Companies ([State])

print '  idx_CompanyID'
print '  idx_ComapnayName'
print '  idx_PostalCode'
print '  idx_City'
print '  idx_State'




/****** Object:  [CONTACTS]    DATABASE TABLE : ******** *:**:** PM ******DTPLAPTOP09*/

CREATE TABLE Contacts (

			 ContactID INT IDENTITY NOT NULL,
			 CompanyID INT FOREIGN KEY REFERENCES Companies (CompanyID) NOT NULL,
			 CourtesyTitle VARCHAR(25) NULL,
			 ContactFirstName VARCHAR(50) NULL,
			 ContactLastName VARCHAR(50) NULL,
			 Title VARCHAR(50) NULL,
			 Phone VARCHAR(14) NULL,
			 Extension VARCHAR(10) NULL,
			 Fax VARCHAR(14) NULL,
			 Email VARCHAR(50) NULL,
			 Comments VARCHAR(255) NULL,
			 Active BIT DEFAULT(1) NOT NULL
			 PRIMARY KEY (ContactID)

			 )

			 PRINT '4 Contacts'

			 print '  idx_ContactID'
			 print '  idx_CompanyID'
			 print '  idx_ContactLastName'
			 print '  idx_Title'


CREATE INDEX idx_ContactID on Contacts (ContactID)
			

CREATE INDEX idx_CompanyID on Contacts (CompanyID)


CREATE INDEX idx_ContactLastName on Contacts (ContactLastName)


CREATE INDEX idx_Title on Contacts (Title)



/****** Object:  [LEADS]    DATABASE TABLE : ********** *:**:** PM ******DTPLAPTOP09*/

--INSERT INTO Leads (JobTitle, [Description], EmploymentType, Location, Active VALUES ('HTML Expert')

CREATE TABLE Leads (

			 LeadID int identity NOT NULL,
			 RecordDate DATETIME DEFAULT GETDATE() NOT NULL,
			 JobTitle VARCHAR (75) NOT NULL,
			 [Description] VARCHAR (255) NULL,
			 EmploymentType VARCHAR(25) NULL,
			 Location VARCHAR(50) NULL,
			 Active BIT DEFAULT(1) NULL,
			 CompanyID INT FOREIGN KEY REFERENCES Companies (CompanyID) NULL,
			 AgencyID INT NULL,
			 ContactID INT FOREIGN KEY REFERENCES contacts(contactid) NULL,
			 SourceID BIGINT FOREIGN KEY REFERENCES Sources (SourceID) NULL,
			 Selected BIT DEFAULT(0) NULL,
			 ModifiedDate DATETIME NULL,
			 PRIMARY KEY (LeadID),
			 CONSTRAINT CK_EmploymentType CHECK (EmploymentType IN ('Full-Time' , 'Part-Time' , 'Salary')) 
			
			 )

			 PRINT '5 Leads'

CREATE INDEX idx_RecordDate on Leads (RecordDate)

CREATE INDEX idx_EmploymentType on Leads (EmploymentType)

CREATE INDEX idx_Location on Leads (Location)

print '  idx_EmploymentType'
print '  idx_Location'

			 /****** Object:  [ACTIVITES]    DATABASE TABLE : ********** *:**:** PM ******DTPLAPTOP09*/

CREATE TABLE Activities (

			 ActivityID int identity NOT NULL,
			 LeadID int FOREIGN KEY REFERENCES Leads (LeadID) NOT NULL,
			 ActivityDate DATETIME NOT NULL,
			 ActivityType VARCHAR(25) NOT NULL,
			 ActivityDetails VARCHAR(255) NULL,
			 Complete BIT DEFAULT(0) NULL,
			 ReferenceLink VARCHAR(255) NULL,
			 ModifiedDate DATETIME NOT NULL,
			 PRIMARY KEY (ActivityID)
 ) ;

			 PRINT '6 Activites'

			 

 CREATE INDEX idx_ActivityID on Activities (ActivityID) ;

				
 CREATE INDEX idx_LeadID on Activities (LeadID) ;
		

 CREATE INDEX idx_ActivityDate on Activities (ActivityDate) ;


 CREATE INDEX idx_ActivityType on Activities (ActivityType) ;
 GO

 print '  idx_ActivityID'
 print '  idx_LeadID' 
 print '  idx_AcitvityDate'
 print '  idx_ActivityType'

 INSERT INTO BusinessTypes (BusinessType) VALUES
('Accounting'), ('Advertising/Marketing'), ('Agriculture'), ('Architecture'),
('Arts/Entertainment'), ('Aviation'), ('Beauty/Fitness'), ('Business Services'), ('Communications'),
('Computer/Hardware'), ('Compute/Services'), ('Computer/Software'), ('Computer/Training'), ('Construction'),
('Consulting'), ('Crafts/Hobbies'), ('Education'), ('Electrical'), ('Electronics'), ('Emplyment'), ('Engineering'),
('Enviormental'), ('Fashion'), ('Finacial'), ('Food/Beverage'), ('Government'), ('Health/Medicine'), ('Home & Garden'),
('Immigration'), ('Import/Export'), ('Industrial'), ('Industrial Medicine'), ('Information Services '), ('Insurance'),
('Internet'), ('Legal & Law'), ('Logistics'), ('Manufacturing'), ('Mapping/Surveying'), ('Marine/Maritime'),
('Motor Vehicle'), ('Multimedia'), ('Network Marketing'), ('News & Weather'), ('Non-Profit'), ('Petrochemical'),
('Pharmacutical'), ('Printing/Publishing'), ('Real Estate'), ('Restaurants'), ('Restaurants Services'),
('Service Clubs'), ('Service Industry'), ('Shopping/Retail'), ('Spiritual/Religious'), ('Sports/Recreation'),
('Storage/Warehousing'), ('Technologies'), ('Transportation'), ('Travel'), ('Utilities'), ('Venture Capital'), ('Wholesale')
GO

INSERT INTO Sources (SourceName, SourceType, SourceLink, [Description]) 
VALUES ('Monster' , 'Online', 'http://www.monster.com', 'Test'),
		('Indeed', 'Online' , 'http://www.indeed.com', 'Test'),
		('HireMe', 'Online' , 'http://www.higherme.com', 'Test'),
		('Snag a Job', 'Online', 'http://www.snagajob.com', 'Test'),
		('Zip Recruiter', 'Online', 'http://www.ziprecriter.com', 'Test'),
		('Career Source' , 'Location', 'http://careersource.com', 'Test'),
		('Hiringnearyou' , 'Online' , 'http://hiringnearyou.com', 'Test'),
		('Linkedin', 'Online', 'http://linkedin.com', 'Test')

		

INSERT INTO LEADS ( JobTitle, [Description], EmploymentType, Location, Active, SourceID)
VALUES ('Html Expert', 'Help People with HTML', 'Part-Time', '7195 Se' , 1, 1) , 
	   ('Front End Developer' , 'Develop with HTML/CSS for trucks and jeeps' , 'Full-Time', NULL, 1, 1) ,
	   ('Wordpress Developer' , 'Designing and implementing new features and functionality' , 'Full-Time' , 'Ocala', 1, 3),
	   ('SEO Analyst' , 'Implement full SEO' , 'Full-Time' , 'Ocala', 1, 3),
	   ('Website Developer' , 'Build Websites for people', 'Full-Time', 'LadyLake', 1, 1),
	   ('Quality Assurance Engineer', 'HTML, CSS, Java, PHP', 'Full-Time', 'Ocala', 1, 3)
	   , ('.NetDeveloper', 'C#.Net', 'Full-Time', 'Ocala', 1, 3)

INSERT INTO Companies (CompanyName)VALUES ('Drewslair'), ('AndrewComeau'), ('Microsoft'), ('Vinergys inc'), ('LibertySoftware')
INSERT INTO Companies (CompanyName, Address1, City, [State], Zip, Phone, Fax, Email, Website, [Description], Agency)
VALUES ('Exeter Employment', '123 Test Lane', 'Orlando', 'FL', '33321', '904-555-5555', '904-555-5555', 'drone@vinergys.com', 'Google.com', 'Test', '1'),
('Zwerl', NULL, 'Ocala', 'FL', NULL, NULL, NULL, NULL, 'http://zwerl.com', 'They want an HTML expert', '0' ),
('Moy Media' , NULL, 'Ocala' , 'FL', NULL, NULL, NULL, NULL, 'http://moymedia.com', 'Ocala Developers', '1'),
('IBM' , 'Armonk, NorthCastle' , NULL, 'NY' , NULL, NULL, NULL, NULL, 'http://idb.com/us', 'Sr. Developer Needed' , '1'),
('RealTruck', NULL, 'Ocala', 'FL', NULL, NULL, NULL, NULL, 'http://realtruck.com', 'Developers' , '1')
GO

INSERT INTO Contacts (CompanyID, CourtesyTitle, ContactFirstName, ContactLastName, Phone, Email, Active) 
VALUES ('1', 'Mr', 'John', 'Smith', '528-589-412', 'JohnSmith@Email.com', 1), ('2', 'Ms', 'Jane', 'Doe', '258-654-632', 'JaneDoe@Email.com', 1), ('3', 'Mr', 'Bill', 'Hunt', '478-256-359', 'BillHunt@Aol.com', 1)	
, ('4', 'Mr', 'Boe', 'Jangles', '864-913-846', 'BoeJangles@Someplace.com', 1), ('5', 'Ms', 'Betty', 'White', '538-846-777', 'SheMakesFood@TheKitchen.com', 1)
, ('6', 'Mr', 'Blake', 'Hoelle', '352-999-854', 'BlakehasEmail@Someplace.com', 1), ('7',  'Mr', 'Fred', 'Flinstone', '555-555-5555', 'Fred@Boomerang.com', 1)

GO

	   INSERT INTO Activities (LeadID, ActivityDate, ActivityType, ActivityDetails, Complete, ModifiedDate) VALUES ((SELECT LeadID from Leads where LeadID = 1) , GETDATE(),
			  'walkin', NULL, '1', GETDATE())
go



 CREATE TRIGGER  Trggr_Leads_ModifiedDate
ON				Leads
AFTER  INSERT , UPDATE
AS
	BEGIN
		
		UPDATE Leads
		SET ModifiedDate = GETDATE()
		PRINT 'Modified Date Changed by Leads_ModifiedDate TRIGGER' 
		 
	END
GO





CREATE TRIGGER  Trggr_Activities_ModifiedDate
ON				Activities
AFTER  INSERT , UPDATE
AS
	BEGIN
		
		UPDATE Activities
		SET ModifiedDate = GETDATE()
		PRINT 'Modified Date Changed by Activities_ModifiedDate TRIGGER'  

	END
GO	

PRINT ''
PRINT 'Trigger Leads_ModifiedDate CREATED'			
PRINT 'Trigger Activities_ModifiedDate CREATED'
	    go

-- 1
CREATE PROC [LeadsPerDay] 
		(
			@StartDate DATETIME
			, @EndDate DATETIME 
		)

		AS

		BEGIN
				SELECT COUNT(LeadID) FROM Leads
				where RecordDate between @StartDate and @EndDate
		END
		GO
-- 2
CREATE PROC [LeadsNeedActivity]
AS
	BEGIN
			SELECT L.LeadID , L.JobTitle [Job Title], C.ContactLastName + ', ' + C.ContactFirstName [LastName, FistName]
			, C.Phone [Contact Number], C.Email
			FROM Activities A
			INNER JOIN	Leads L
			ON A.LeadID = L.LeadID
			INNER JOIN Contacts C
			ON C.CompanyID = L.CompanyID
			WHERE A.ModifiedDate < DATEADD(DAY, -7, GETDATE())


	END
	GO
-- 3
CREATE PROC [LeadsbySource]
AS
	BEGIN
			SELECT COUNT(L.LeadID) [Number of Leads], S.SourceName FROM Leads L
			INNER JOIN Sources S
			ON L.SourceID = S.SourceID
			GROUP BY S.SourceName
			HAVING COUNT(L.LeadID) > 0
			
	END 
	GO
-- 4
CREATE PROC [ActiveContactList]
AS
	BEGIN
			select Com.CompanyName, Con.ContactLastName + ', ' + Con.ContactFirstName [LastName FirstName], Con.Phone,
			Con.Email, Con.Comments from Contacts Con
			inner join Companies Com
			on Con.CompanyID = Com.CompanyID
			WHERE Con.Active = 1
	END
	GO
-- 5
CREATE PROC [CallList]
AS
	BEGIN
			SELECT DATEDIFF(Day, GetDate(), ModifiedDate)  FROM Leads L
			INNER JOIN	Companies Com
			on L.CompanyID = Com.CompanyID
			INNER JOIN Contacts Con
			on Com.CompanyID = Con.CompanyID
			WHERE L.Active = 1 AND COUNT(DATEDIFF(Day, GetDate(), ModifiedDate)) > 1
	END
	GO
-- 6 
CREATE PROC [SearchLog]
	(
			@StartDate DATETIME
			, @EndDate DATETIME 
		)
AS
	
	BEGIN
			SELECT A.ActivityDate, A.ActivityType, L.JobTitle [Job Title], C.CompanyName [Contact CompanyName]
			, C.Phone, C.Email  FROM Leads L
			INNER JOIN Activities A
			ON A.LeadID = L.LeadID
			LEFT JOIN Companies C
			ON L.CompanyID = C.CompanyID
			WHERE A.ActivityDate BETWEEN @StartDate AND @EndDate

			
	END	
	GO	
-- 7
CREATE PROC [LeadReport]
AS
	BEGIN
			SELECT L.LeadID, C.CompanyName [Company Name], CONCAT(C.Agency, Con.ContactFirstName + ', ' + Con.ContactLastName) [FName, LName]
			, Con.CourtesyTitle, Con.Phone, Con.Email, S.SourceName
			FROM Leads L
			INNER JOIN Companies C
			ON L.CompanyID = C.CompanyID
			INNER JOIN Contacts Con
			ON C.CompanyID = Con.CompanyID
			INNER JOIN Sources S
			ON L.SourceID = S.SourceID
			WHERE L.Active = 1
	END
	go

CREATE PROC [InsertLeads]
AS
	BEGIN
			SELECT RecordDate, JobTitle, [Description], EmploymentType, Location FROM Leads
	END






















