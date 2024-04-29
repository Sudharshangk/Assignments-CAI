--Q1. Write a SQL statement that displays all the information about all salespeople
CREATE TABLE salespeople (
  salesman_id INT PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  city VARCHAR(50) NOT NULL,
  commission DECIMAL(5,2) NOT NULL
);

INSERT INTO salespeople (salesman_id, name, city, commission)
VALUES
  (5001, 'James Hoog', 'New York', 0.15),
  (5002, 'Nail Knite', 'Paris', 0.13),
  (5005, 'Pit Alex', 'London', 0.11),
  (5006, 'Mc Lyon', 'Paris', 0.14),
  (5007, 'Paul Adam', 'Rome', 0.13),
  (5003, 'Lawson Hen', 'San Jose', 0.12);
SELECT * FROM salespeople

--Q2. Write a SQL statement to display a string 
--"This is SQL Exercise, Practice and Solution".
SELECT 'This is SQL Exercise, Practice and Solution'

--Q3. Write a SQL query to display three numbers in three columns.
SELECT 1 AS Num1 , 2 AS Num2, 3 AS Num3;


--Q4. Write a SQL query to display the sum of two numbers 10 and 15 from the RDBMS server.
SELECT 10 + 15;

--Q5 Write an SQL query to display the result of an arithmetic expression.
SELECT 5 * 3 AS result_of_expression;
SELECT 10 + 30;
SELECT 40-20;

--6 Write a SQL statement to display specific columns such as
--names and commissions for all salespeople.
SELECT name, commission
FROM salespeople;


CREATE TABLE orders (
    ord_no INT,
    purch_amt DECIMAL(10, 2),
    ord_date DATE,
    customer_id INT,
    salesman_id INT
);

INSERT INTO orders (ord_no, purch_amt, ord_date, customer_id, salesman_id) 
VALUES 
(70001, 150.5, '2012-10-05', 3005, 5002),
(70009, 270.65, '2012-09-10', 3001, 5005),
(70002, 65.26, '2012-10-05', 3002, 5001),
(70004, 110.5, '2012-08-17', 3009, 5003),
(70007, 948.5, '2012-09-10', 3005, 5002),
(70005, 2400.6, '2012-07-27', 3007, 5001),
(70008, 5760, '2012-09-10', 3002, 5001),
(70010, 1983.43, '2012-10-10', 3004, 5006),
(70003, 2480.4, '2012-10-10', 3009, 5003),
(70012, 250.45, '2012-06-27', 3008, 5002),
(70011, 75.29, '2012-08-17', 3003, 5007),
(70013, 3045.6, '2012-04-25', 3002, 5001);

select * from orders

--7 Write a query to display the columns in a specific order, such as order date, salesman ID,
--order number, and purchase amount for all orders.
SELECT ord_date, salesman_id, ord_no, purch_amt
FROM orders
WHERE ord_date = '2012-10-10';


SELECT ord_date, salesman_id, ord_no, purch_amt
FROM orders
WHERE salesman_id = 5001 ;

--8 From the following table, write a SQL query to 
--identify the unique salespeople ID. Return salesman_id.

SELECT DISTINCT salesman_id
FROM orders;

--Q9 From the following table, write a SQL query to locate salespeople 
--who live in the city of 'Paris'. Return salesperson's name, city.

SELECT name, city
FROM salespeople
WHERE city = 'Paris';

--Q10. From the following table, write a SQL query to find customers whose grade is
--200. Return customer_id, cust_name, city, grade, salesman_id.

CREATE TABLE customers1 (
    customer_id INT PRIMARY KEY,
    cust_name VARCHAR(50),
    city VARCHAR(50),
    grade INT,
    salesman_id INT
);
INSERT INTO customers1 (customer_id, cust_name, city, grade, salesman_id) 
VALUES 
    (3002, 'Nick Rimando', 'New York', 100, 5001),
    (3007, 'Brad Davis', 'New York', 200, 5001),
    (3005, 'Graham Zusi', 'California', 200, 5002),
    (3008, 'Julian Green', 'London', 300, 5002),
    (3004, 'Fabian Johnson', 'Paris', 300, 5006),
    (3009, 'Geoff Cameron', 'Berlin', 100, 5003),
    (3003, 'Jozy Altidor', 'Moscow', 200, 5007),
    (3001, 'Brad Guzan', 'London', NULL, 5005);
GO

SELECT * FROM customers1
 
SELECT customer_id, cust_name, city, grade, salesman_id
FROM customers1
WHERE grade = 200;



select *from orders
--Q11From the following table, write a SQL query to find orders that are delivered by a 
--salesperson with ID. 5001. Return ord_no, ord_date, purch_amt.
select ord_no,ord_date,purch_amt from orders where salesman_id = 5001

--Q12From the following table, write a SQL query to find the Nobel Prize winner(s) 
--for the year 1970. Return year, subject and winner.

CREATE TABLE NobelPrizeWinner(
	YEAR INT, 
	SUBJECT varchar(50), 
	WINNER varchar(50), 
	COUNTRY varchar(50), 
	CATAGORY varchar(50)
);

select *from NobelPrizeWinner

INSERT INTO NobelPrizeWinner VALUES(1970, 'Physics', 'Hannes Alfven', 'Sweden', 'Scientist'),
       (1975, 'Physics', 'Louis Neel', 'France', 'Scientist'),
       (1972, 'Chemistry', 'Luis Federico Leloir', 'Argentina', 'Scientist'),
       (1970, 'Physiology', 'Ulf von Euler', 'Sweden', 'Scientist'),
       (1975, 'Physiology', 'Bernard Katz', 'Germany', 'Scientist'),
       (1970, 'Literature', 'Aleksandr Solzhenitsyn', 'Russia', 'Linguist');

SELECT YEAR,SUBJECT, WINNER FROM NobelPrizeWinner WHERE YEAR = 1970

--Q13. From the following table, write a SQL query to find the Nobel Prize winner 
--in ‘Literature’ for 1970. Return winner.

SELECT WINNER FROM NobelPrizeWinner WHERE YEAR = 1970 AND SUBJECT = 'Literature'

--Q14. From the following table, write a SQL query to locate the Nobel Prize winner 
--‘Bernard Katz'. Return year, subject.
SELECT YEAR, SUBJECT FROM NobelPrizeWinner WHERE WINNER = 'Bernard Katz';

--Q15. From the following table, write a SQL query to find the Nobel Prize winners
--in the field of ‘Physics’ since 1975. Return winner.

SELECT WINNER FROM NobelPrizeWinner WHERE SUBJECT = 'Physics' AND YEAR >= 1975

--Q16. From the following table, write a SQL query to find the Nobel Prize winners
--in ‘Chemistry’ between the years 1970 and 1975. Begin and end values are included. 
--Return year, subject, winner, and country.

SELECT YEAR,SUBJECT,WINNER,COUNTRY FROM NobelPrizeWinner 
WHERE SUBJECT='Chemistry' AND YEAR BETWEEN 1970 AND 1975

SELECT YEAR, SUBJECT, WINNER, COUNTRY
FROM NobelPrizeWinner
WHERE YEAR >= 1970 AND YEAR <= 1975 AND SUBJECT = 'Chemistry';


--Q17. Write a SQL query to display all details of the Prime Ministerial winners 
--after 1971 of Bernard Katz and Louis Neel.

SELECT *
FROM NobelPrizeWinner
WHERE YEAR > 1971 AND (WINNER = 'Bernard Katz' OR WINNER = 'Louis Neel');

--Q18. From the following table, write a SQL query to retrieve the details of
--the winners whose first names match with the string ‘Louis’.
--Return year,- subject, winner, country, and category.

SELECT YEAR, SUBJECT, WINNER, COUNTRY, CATAGORY
FROM NobelPrizeWinner
WHERE WINNER LIKE 'Louis%';

--Q19. From the following table, write a SQL query that combines the winners 
--in Physics, 1970 and in Chemistry, 1972. 
--Return year, subject, winner, country, and category.

SELECT YEAR, SUBJECT, WINNER, COUNTRY, CATAGORY
FROM NobelPrizeWinner
WHERE (YEAR = 1970 AND SUBJECT = 'Physics')
OR (YEAR = 1972 AND SUBJECT = 'Chemistry');


SELECT YEAR, SUBJECT, WINNER, COUNTRY, CATAGORY
FROM NobelPrizeWinner
WHERE YEAR = 1970 AND SUBJECT = 'Physics'
UNION 
SELECT YEAR, SUBJECT, WINNER, COUNTRY, CATAGORY
FROM NobelPrizeWinner
WHERE YEAR = 1972 AND SUBJECT = 'Chemistry';


--Q20. From the following table, write a SQL query to
--find the Nobel Prize winners in 1970 excluding the subjects of Physics and Literature.
--Return year, subject, winner, country, and category.

SELECT YEAR, SUBJECT, WINNER, COUNTRY, CATAGORY
FROM NobelPrizeWinner
WHERE YEAR = 1970 AND SUBJECT NOT IN ('Physics', 'Literature');
GO

--21 . From the following table, write a SQL query to find the details of
--those salespeople who come from the 'Paris' City or 'Rome' City. 
--Return salesman_id, name, city, commission.
SELECT * FROM salespeople
SELECT salesman_id, name, city, commission FROM salespeople WHERE city IN( 'PARIS','ROME' )


--Q22. From the following table, write a SQL query to retrieve the details
--of all customers whose ID belongs to any of the values 3007, 3008 or 3009.
--Return customer_id, cust_name, city, grade, and salesman_id.

SELECT *FROM customers1

SELECT customer_id, cust_name, city, grade, salesman_iD 
FROM customers1 
WHERE customer_id IN (3007,3008,3009)

--Q23. From the following table, write a SQL query to select orders
--between 500 and 4000 (begin and end values are included). 
--Exclude orders amount 948.50 and 1983.43. 
--Return ord_no, purch_amt, ord_date, customer_id, and salesman_id.

SELECT * FROM orders

SELECT ord_no, purch_amt, ord_date, customer_id,salesman_id FROM orders
WHERE purch_amt BETWEEN 500 AND 4000
AND purch_amt NOT IN (948.50,1983.43)


--Q24. From the following table, write a SQL query to retrieve the details 
--of the salespeople whose names begin with any letter between 'A' and 'L' (not inclusive).
--Return salesman_id, name, city, commission.

SELECT * FROM salespeople

SELECT salesman_id, name , city,commission FROM salespeople
WHERE NAME NOT LIKE 'A%' AND NAME NOT LIKE 'L%'

--Q25. From the following table, write a SQL query to retrieve 
--the details of the customers whose names begins with the letter 'B'.
-- Return customer_id, cust_name, city, grade, salesman_id

SELECT * FROM customers1

SELECT customer_id, cust_name, city, grade, salesman_id FROM customers1
WHERE cust_name LIKE 'B%'