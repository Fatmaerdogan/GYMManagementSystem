CREATE TABLE CUSTOMER
(
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id VARCHAR(MAX) NULL,
    fullname VARCHAR(MAX) NULL,
    phone_number VARCHAR(MAX) NULL,
    gender VARCHAR(MAX) NULL,
    program_type VARCHAR(MAX) NULL,
    age INT NULL,
    weight INT NULL,
    height  INT NULL,
    salary  INT NULL,
    active INT NULL
)

SELECT * FROM customers

CREATE TABLE USERS
(
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(MAX) NULL,
    password VARCHAR(MAX) NULL,
    date_register DATE NULL
)
SELECT * FROM users

CREATE TABLE PROGRAM(
    id INT PRIMARY KEY IDENTITY(1,1),
    programname VARCHAR(MAX) NULL,
    movementname VARCHAR(MAX) NULL,
    repeats_number  INT NULL,
    sets_number INT NULL
)
SELECT * FROM program
