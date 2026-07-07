CREATE DATABASE LMS;


USE LMS;


CREATE TABLE login (
    Id    INT IDENTITY(1,1) PRIMARY KEY,
    Name  VARCHAR(50) NOT NULL,
    Pass  VARCHAR(50) NOT NULL
);

INSERT INTO login (Name, Pass) VALUES ('Arqam', '8758');
INSERT INTO login (Name, Pass) VALUES ('Saad', '8750');

SELECT * FROM login;


-- Add Books Form
CREATE TABLE Books (
    BookId       INT IDENTITY(1,1) PRIMARY KEY,
    BookCode     AS ('B' + RIGHT('000' + CAST(BookId AS VARCHAR), 3)) PERSISTED,
    BookName     VARCHAR(100) NOT NULL,
    AuthorName   VARCHAR(100) NOT NULL,
    Publisher    VARCHAR(100) NOT NULL,
    BookPrice    DECIMAL(10,2) NOT NULL,
    BookQuantity INT NOT NULL,
    DateAdded    DATE NOT NULL
);

SELECT * FROM Books;


-- Add Student Form
CREATE TABLE Students (
    StudentID   INT IDENTITY(1,1) PRIMARY KEY,
    Name        VARCHAR(100)  NOT NULL,
    Enrollment  VARCHAR(50)   NOT NULL UNIQUE,
    Department  VARCHAR(100)  NOT NULL,
    Semester    VARCHAR(20)   NOT NULL,
    Contact     VARCHAR(20)   NOT NULL,
    Email       VARCHAR(100)  NOT NULL,
    DateAdded   DATE          NOT NULL DEFAULT GETDATE()
);

SELECT * FROM Students;


-- Issue Books Form
CREATE TABLE IssuedBooks (
    IssueId        INT IDENTITY(1,1) PRIMARY KEY,
    EnrollmentNo   VARCHAR(50)  NOT NULL,
    StudentName    VARCHAR(100) NOT NULL,
    StudentEmail   VARCHAR(100) NOT NULL,
    StudentContact VARCHAR(20)  NOT NULL,
    Semester       VARCHAR(20)  NOT NULL,
    Department     VARCHAR(100) NOT NULL,
    BookName       VARCHAR(100) NOT NULL,
    IssueDate      DATE         NOT NULL,
    ReturnDate     DATE         NULL,
    Status         VARCHAR(20)  DEFAULT 'Issued'
);

SELECT * FROM IssuedBooks;