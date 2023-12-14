use Library;

-- how to make a table in sql server
CREATE TABLE Libraries (
  id int NOT NULL PRIMARY KEY IDENTITY(1, 1),
  [name] nvarchar(255) NOT NULL,
  [address] nvarchar(255) NOT NULL,
);


-- CRUD OPERATIONS
-- C stands for create
-- R stands for read
-- U stands for update
-- D stands for delete


-- C for CRUD
-- how to add a row to a table
-- when inserting into a table, you must specify the columns you are inserting into
-- in this case, we are exluding the id column because it is an identity column
-- an identity column is a column that is automatically incremented by the database
INSERT INTO Libraries ([address], [name]) -- the columns are listed in the same order as the values
VALUES ('123 Main St.', 'Central Library')

INSERT INTO Libraries ([address], [name]) -- the columns are listed in the same order as the values
VALUES ('1001 Grand Circus Blvd.', 'Grand Circus Library')


-- R in CRUD
SELECT * from Libraries

-- U in CRUD
-- how to update a row to a table
-- when updating a row, you must specify the columns you are updating
UPDATE Libraries 
SET [name] = 'Grand Circus Library'


-- D in CRUD
-- how to delete a row from a table
-- when deleting a row, you must specify the columns you are deleting
-- ONCE YOUR ROW IS GONE, IT IS GONE FOREVER!!! BE VERY VERY CAREFUL!!!
DELETE FROM Libraries
WHERE id = 2

CREATE TABLE Books(
    id int NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [title] nvarchar(255) NOT NULL,
    [author] nvarchar(255) NOT NULL,
    [state] nvarchar(50) NOT NULL,

    [libraryId] int NOT NULL FOREIGN KEY REFERENCES Libraries(id)
);

exec sp_rename 'Library', 'Libraries'


INSERT INTO Books ([title], [author], [state], [libraryId]) -- the columns are listed in the same order as the values
VALUES
    ('C# for dummies', 'James Jackson', 'On Shelf', 2),
    ('Javascript for webdevs', 'Jay', 'On Shelf', 2),
    ('Java for nerds', 'David', 'Checked Out', 2),
    ('The Eye of the World', 'Robert Jordan', 'On Shelf', 1),
    ('Tomorrow and Tomorrow and Tomorrow', 'Gabrielle Zevin', 'On Shelf', 1),
    ('Wellness: A Novel', 'Nathan Hill', 'On Shelf', 1)

SELECT Title, Author from Books
INNER JOIN Libraries 
ON Books.libraryId = Libraries.Id
WHERE Libraries.Id = 1;


-- sql server indexes
CREATE INDEX idx_book_title
ON Books (title); 

SELECT * from Books
WHERE title = 'C# for dummies';

-- Views... a view is a virtual table based on the result-set of an SQL statement.
CREATE VIEW [Book Titles] AS
SELECT Title from Books

Select * from [Book Titles]

CREATE VIEW [Library Books] AS
SELECT Title as [Book Title], Author as [Book Author], [name] as [Library Name] from Books
INNER JOIN Libraries 
ON Books.libraryId = Libraries.Id
where Title = 'C# for dummies'

SELECT * FROM [Library Books]
where [Book Title] = 'C# for dummies'

-- Stored Procedures AKA Stored Procs AKA SProcs
CREATE PROCEDURE SelectAllBooks AS
  Select * from Books
GO;

exec SelectAllBooks;

-- parameters in stored procedures start with an '@' symbol
CREATE PROCEDURE SelectAllBooksByTitle @title nvarchar(255) AS
  Select * from Books
  where Title = @title
GO;

exec SelectAllBooksByTitle 'C# for dummies';

CREATE PROCEDURE InsertNewBook @title nvarchar(255), @author nvarchar(255), @libraryId int AS
  INSERT INTO Books ([title], [author], [state], [libraryId]) -- the columns are listed in the same order as the values
  VALUES
      (@title, @author, 'On Shelf',  @libraryId)
GO

exec InsertNewBook 'The Eye of the World', 'Robert Jordan', 1

exec SelectAllBooks