/****** Question 1 - Query to find Second Highest Salary of Employee?  ******/
SELECT MAX(salary) [Second Highest Salary]  
FROM employees  
WHERE salary NOT IN (SELECT MAX(salary) FROM employees) 


/****** Question 2 - Query to find Third Highest Salary of Employee?  ******/
SELECT MAX(salary)  
FROM employees  
WHERE salary NOT IN (SELECT DISTINCT TOP 2 salary   
                     FROM employees  
                     ORDER BY salary DESC)  

/****** Question 3 - Find and Remove Duplicate Rows from a Database Table??  ******/
DELETE  
FROM employees   
WHERE Id NOT IN (SELECT MIN(Id)   
FROM employees  
GROUP BY name, salary, ManagerId)  