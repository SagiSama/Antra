--All scenarios are based on Database NORTHWIND.
Use Northwind
--1.      List all cities that have both Employees and Customers.
SELECT *
FROM
(SELECT City
FROM Employees
Union
SELECT City
FROM Customers) AS c
WHERE c.city IN (SELECT City FROM Employees) 
AND c.city IN (SELECT City FROM Customers)

SELECT DISTINCT e.City
FROM Employees e
INNER JOIN Customers c
ON c.City = e.City

--2.      List all cities that have Customers but no Employee.
SELECT DISTINCT City
FROM Customers
WHERE City NOT IN 
(SELECT City FROM Employees) 

--a.      Use sub-query
--b.      Do not use sub-query
--3.      List all products and their total order quantities throughout all orders.
SELECT ProductID, ProductName, 
    (SELECT COUNT(ProductID) AS Count 
     FROM [Order Details] od 
     WHERE od.ProductID = p.ProductID 
     GROUP BY ProductID) AS Count
FROM Products p

SELECT p.ProductID, p.ProductName, COUNT(od.ProductID) AS Count
FROM Products p
JOIN [Order Details] od
ON od.ProductID = p.ProductID
GROUP BY od.ProductID, p.ProductID, p.ProductName

--4.      List all Customer Cities and total products ordered by that city.
SELECT DISTINCT c.City,
       (SELECT COUNT(o.ShipCity)
        FROM Orders o
        WHERE o.ShipCity = c.City
        GROUP BY o.ShipCity) AS OrdersCount
FROM Customers c

SELECT DISTINCT c.City, COUNT(o.OrderID) AS OrdersCount
FROM Customers c
JOIN Orders o
ON o.ShipCity = c.City
GROUP BY c.City

--5.      List all Customer Cities that have at least two customers.
SELECT u.City, u.OrdersCount FROM
    (SELECT DISTINCT c.City,
        (SELECT COUNT(o.ShipCity)
         FROM Orders o
         WHERE o.ShipCity = c.City
         GROUP BY o.ShipCity) AS OrdersCount
    FROM Customers c) u
WHERE u.OrdersCount > 2

SELECT DISTINCT c.City, COUNT(o.OrderID) AS OrdersCount
FROM Customers c
JOIN Orders o
ON o.ShipCity = c.City
GROUP BY c.City
HAVING(COUNT(o.OrderID)) > 2

--a.      Use union
--b.      Use sub-query and no union
--6.      List all Customer Cities that have ordered at least two different kinds of products.
SELECT City
FROM Customers
UNION
SELECT o.ShipCity
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
GROUP BY o.OrderID, o.ShipCity
HAVING(COUNT(od.ProductID)) > 2

SELECT City FROM Customers
WHERE City IN
(SELECT o.ShipCity
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
GROUP BY o.OrderID, o.ShipCity
HAVING(COUNT(od.ProductID)) > 2)

--7.      List all Customers who have ordered products, but have the ‘ship city’ on the order different from 
            --their own customer cities.
SELECT CustomerID, ContactName 
FROM Customers c
WHERE CustomerID IN
(SELECT CustomerId FROM Orders WHERE c.City != ShipCity)

--8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 ProductName, AVG(p.UnitPrice), c.City, Count(od.Quantity)
FROM Products p
JOIN [Order Details] od
ON od.ProductID = p.ProductID
JOIN Orders o
ON o.OrderID = od.OrderID
JOIN Customers c
ON c.CustomerID = o.CustomerID
GROUP BY p.ProductID, p.ProductName, c.City
Order BY Count(od.Quantity) DESC

-- UnitPrice, RANK() OVER(ORDER BY UnitPrice DESC ) RNK

--9.      List all cities that have never ordered something but we have employees there.
SELECT City
FROM Employees
WHERE City NOT IN
(select ShipCity from Orders)

SELECT ProductId, ProductName, UnitPrice, RANK() OVER(ORDER BY UnitPrice DESC ) RNK
from Products
--a.      Use sub-query
--b.      Do not use sub-query
--10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
SELECT TOP 1 City, COUNT(o.OrderID) AS Count, RANK() OVER(ORDER BY COUNT(o.OrderID) DESC) AS RNK
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
GROUP BY c.City
UNION
SELECT TOP 1 o.ShipCity AS City, COUNT(od.Quantity) AS Count, RANK() OVER(ORDER BY COUNT(od.Quantity) DESC) AS RNK
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
GROUP BY o.ShipCity

CREATE VIEW vw1
AS
SELECT TOP 1 City, COUNT(o.OrderID) AS Count
FROM Customers c
JOIN Orders o
ON o.CustomerID = c.CustomerID
GROUP BY c.City
ORDER BY COUNT(o.OrderID) DESC

CREATE VIEW vw2
AS
SELECT TOP 1 o.ShipCity AS City, COUNT(od.Quantity) AS Count
FROM Orders o
JOIN [Order Details] od
ON od.OrderID = o.OrderID
GROUP BY o.ShipCity
ORDER BY COUNT(od.Quantity) DESC

SELECT * FROM vw1 UNION SELECT * FROM vw2;

--11. How do you remove the duplicates record of a table?
--using DISTINCT or GROUP BY.