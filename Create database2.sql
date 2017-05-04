-- New database

CREATE TABLE Collection1 (
Collection_name VARCHAR (255) NOT NULL,
Foreign_language VARCHAR (255) NOT NULL,
Foreign_word VARCHAR (255) NOT NULL PRIMARY KEY,
Translation_language VARCHAR (255) NOT NULL,
Translation_word VARCHAR (255) NOT NULL,
Actualization TIMESTAMP NOT NULL, 
OWNER VARCHAR (255) NOT NULL, 
Status int DEFAULT 1);

CREATE TABLE Collection3 (
Collection_name VARCHAR (255) NOT NULL,
Foreign_language VARCHAR (255) NOT NULL,
Foreign_word VARCHAR (255) NOT NULL PRIMARY KEY,
Translation_language VARCHAR (255) NOT NULL,
Translation_word VARCHAR (255) NOT NULL,
Actualiation TIMESTAMP NOT NULL, 
OWNER VARCHAR (255) NOT NULL, 
Status int DEFAULT 1);
 
 CREATE TABLE Collections (
 Collection_ID int NOT NULL PRIMARY KEY,
 Collection_name VARCHAR(255) NOT NULL,
 Owner VARCHAR (255) NOT NULL);
 
 CREATE TABLE Languages (
 Language VARCHAR(255) PRIMARY KEY);
 
CREATE TABLE Polish (
Language VARCHAR(255) DEFAULT 'Polish',
Word VARCHAR(255) NOT NULL PRIMARY KEY,
Notes BLOB);

CREATE TABLE English (
Language VARCHAR(255) DEFAULT 'English',
Word VARCHAR(255) NOT NULL PRIMARY KEY,
Notes BLOB);

CREATE TABLE Spanish (
Language VARCHAR(255) DEFAULT 'Spanish',
Word VARCHAR(255) NOT NULL PRIMARY KEY,
Notes BLOB);

CREATE TABLE Users (
User_name VARCHAR(255) NOT NULL PRIMARY KEY,
Creation_data TIMESTAMP,
PASSWORD VARCHAR (255));

CREATE TABLE Tests (
Test_ID int NOT NULL PRIMARY KEY,
User_name VARCHAR(255) NOT NULL, 
Data TIMESTAMP NOT NULL,
Collection_name VARCHAR(255) NOT NULL,
Quantity_of_words int NOT NULL,
Correct_answers int NOT NULL, 
Incorrect_answers int NOT NULL);

-- Create generators

CREATE GENERATOR gen_test_ID;
SET GENERATOR gen_test_ID TO 0;

CREATE GENERATOR gen_collections_ID;
SET GENERATOR gen_collections_ID TO 0;

-- Triggers

SET TERM !!;

CREATE TRIGGER TR_test_ID FOR Tests
ACTIVE BEFORE INSERT POSITION 0
AS
BEGIN
IF (NEW.Test_ID IS NULL) THEN NEW.Test_ID = GEN_ID(gen_test_ID, 1);
END!!

CREATE TRIGGER TR_collections_id FOR Collections
ACTIVE BEFORE INSERT POSITION 0
AS
BEGIN
IF (NEW.Collection_ID IS NULL) THEN NEW.Collection_ID = GEN_ID(gen_collections_ID, 1);
END!!

SET TERM ;!!

-- Foreign keys

ALTER TABLE Collection1  ADD CONSTRAINT FK_Collection1_foreign_word FOREIGN KEY (Foreign_word)
REFERENCES English(Word);

ALTER TABLE Collection1 ADD CONSTRAINT FK_Collection1_translation FOREIGN KEY (Translation_word)
REFERENCES Polish(Word);

ALTER TABLE Collection1  ADD CONSTRAINT FK_Collection1_owner FOREIGN KEY (Owner)
REFERENCES Users(User_name);

ALTER TABLE Tests  ADD CONSTRAINT FK_Tests_user FOREIGN KEY (User_name)
REFERENCES Users(User_name);

-- Example data

INSERT INTO English (Word) VALUES ('factorial');
INSERT INTO Polish (WORD) VALUES ('silnia');
INSERT INTO Users (User_name, Creation_data) VALUES ('sysdba', '2017-10-12 20:11:11');

INSERT INTO Collection1 VALUES ('Collection1', 'English', 'factorial',
'Polish', 'silnia', '2017-10-12 20:11:11', 'sysdba', 1);


INSERT INTO English (Word) VALUES ('distinguished by');
INSERT INTO Polish (WORD) VALUES ('odróżniany przez');

INSERT INTO Collection1 VALUES ('Collection1', 'English', 'distinguished by',
'Polish', 'odróżniany przez', '2017-10-12 20:11:11', 'sysdba', 1);

INSERT INTO Languages VALUES ('English');
INSERT INTO Languages VALUES ('Polish');

COMMIT;


