-- Question 1: Query to display the name (first name and last name) for those employees who gets
-- more salary than the employee whose ID is 163 --
select first_name + ', ' + last_name as full_name from employees where salary > (select salary from employees where employee_id = '163')
-- Question 2: Query to display the name ( first name and last name ), salary, department id, job id for those employees 
--who works in the same designation as the employee works whose id is 169 --
select first_name + ', ' + last_name as full_name , job_id, D.department_id
from employees E
inner join departments D on D.department_id = E.department_id 
where E.employee_id = 169
-- Question 3: Query to display the name ( first name and last name ), salary, department id for those employees 
--who earn such amount of salary which is the smallest salary of any of the departments --
select first_name, last_name, salary, department_id  
from employees  where salary IN  ( select MIN(salary)  from employees  group by department_id )
-- Question 4: Query to display the employee id, employee name (first name and last name ) for all employees 
--who earn more than the average salary --
select
	 first_name + ', ' + last_name as full_name,
	  employee_id 
	  from employees 
	  where salary > (select AVG(salary) from employees )
-- Question 5: Query to display the employee name ( first name and last name ), 
--employee id and salary of all employees who report to Payam --
select
	 E.first_name + ', ' + E.last_name as full_name,
	  E.employee_id 
	  from employees E 
	  	  inner join employees M on E.manager_id = M.employee_id
	  where M.first_name like '%Payam%'
-- Question 6: Query to display the department number, name ( first name and last name ), job and department name 
--for all employees in the Finance department --
select
	 E.first_name + ', ' + E.last_name as full_name,
	  E.employee_id 
	  from employees E
	  inner join jobs J on E.job_id= J.job_id
	  inner join departments D on E.department_id = D.department_id
	  where D.department_name = 'Finance'
-- Question 7: Query to display all the information of an employee 
--whose salary and reporting person id is 3000 and 121 respectively --
select * from employees where salary  = '3000' and manager_id = '121'
-- Question 8: Display all the information of an employee whose id is any of the number 134, 159 and 183 --
select * from employees where employee_id in (134,  159 , 183)
-- Question 9: Query to display all the information of the employees whose salary is within the range 1000 and 3000 --
select * from employees where salary  between 1000 and  3000
-- Question 10: Query to display all the information of the employees whose salary is within the range of smallest salary and 2500 --
 select * from employees where salary  between (select MIN(salary) from  employees) and 2500
-- Question 11: Query to display the employee name( first name and last name ) and department for all employees 
--for any existence of those employees whose salary is more than 3700 --
select  first_name + ', ' + last_name as full_name , department_id
from employees E 
where EXISTS
(select *  from employees where salary > 3700)
-- Question 12: Query to display the department id and the total salary for those departments which contains at least one employee --
select  SUM(E.salary) , D.department_id
from employees E 
inner join departments D ON E.department_id = D.department_id
Group by D.department_id
-- Question 13: Query to display the employee id, name ( first name and last name ) and the job id column 
--with a modified title SALESMAN for those employees whose job title is ST_MAN and DEVELOPER for whose job title is IT_PROG --
select
	[employee_id]
	,CASE [job_title]
		WHEN N'ST_MAN' THEN 'SALEMAN'
		WHEN N'IT_PROG' THEN 'DEVELOPER'
		ELSE [job_title]
	END [job_title]
from [dbo].[employees] E
	JOIN [dbo].[jobs] J
		ON E.[job_id] = J.[job_id]
-- Question 14: Query to display the employee id, name ( first name and last name ), salary
-- and the SalaryStatus column with a title HIGH and LOW respectively 
--for those employees whose salary is more than and less than the average salary of all employees --

-- Question 15: Query to display the employee id, name ( first name and last name ), SalaryDrawn, 
--AvgCompare (salary - the average salary of all employees) and the SalaryStatus column with a title HIGH and LOW respectively 
--for those employees whose salary is more than and less than the average salary of all employees --

-- Question 16: Query to find all departments that do actually have one or more employees assigned to them --

-- Question 17: Query that will identify all employees who work in departments located in the United Kingdom --
select E.*
from employees E 
    JOIN departments D
    ON E.department_id = D.department_id 
        JOIN locations L 
        ON D.location_id = L.location_id 
where L.country_id = 'UK'
-- Question 18: Query to identify all the employees who earn more than the average of  who work in any of the IT departments --
select * from employees E 
inner join departments D ON E.department_id = D.department_id
 where E.salary > (select AVG(salary) from employees)  and D.department_name like '%IT%'
-- Question 19: Query to determine who earns more than Mr. Ozer --
select * from employees where first_name = 'Ozer'
-- Question 20: Query to find out which employees have a manager who works for a department based in the US --
select E.* from  employees E
inner join employees M ON E.employee_id = M.manager_id
inner join departments D ON E.department_id = D.department_id
inner join locations L ON L.location_id = D.location_id
where L.country_id = 'US'
-- Question 21: Query which is looking for the names of all employees whose salary is greater than 50% of their department’s total salary bill --
select e1.first_name, e1.last_name 
from employees e1 
where salary > 
( select (SUM(salary))*0.5 
from employees e2 
where e1.department_id=e2.department_id);
-- Question 22: Query to get the details of employees who are managers --
select * from employees where employee_id in (select manager_id from employees)
-- Question 23: Query to get the details of employees who manage a department --
select * from employees where employee_id = ANY (select manager_id from departments) 
-- Question 24: Query to display the employee id, name ( first name and last name ), salary, department name and city 
--for all the employees who gets the salary as the salary earn by the employee 
--which is maximum within the joining person January 1st, 2002 and December 31st, 2003 --
 --
select first_name, last_name, salary, department_id from employees
where department_id in (select department_id from departments 
where location_id = (select location_id from locations where city = 'London'))
-- Question 26: Query to display the first and last name, salary, and department ID 
--for all those employees who earn more than the average salary and arrange the list in descending order on salary --
select first_name, last_name , salary, department_id 
  from employees   where salary > (select AVG(salary)from employees ) order by salary desc;
-- Question 27: Query to display the first and last name, salary, and department ID for those employees
-- who earn more than the maximum salary of a department which ID is 40 --
select first_name, last_name, salary, department_id 
 from employees where salary > ALL    (select salary   from employees   where department_id = 40);
-- Question 28: Query to display the department name and Id for all departments where they located, 
--that Id is equal to the Id for the location where department number 30 is located --
select department_id, department_id from departments
 where location_id = (select  location_id from departments where department_id = 30)--select * from departments
-- Question 29: Query to display the first and last name, salary, and department ID for all those employees
-- who work in that department where the employee works who hold the ID 201 --
select first_name, last_name, salary, department_id from employees 
where department_id = (select department_id from employees where employee_id = 201 )
-- Question 30: Query to display the first and last name, salary, and department ID for those employees
-- whose salary is equal to the salary of the employee who works in that department which ID is 40 --
select first_name, last_name, salary, department_id from employees 
where salary in (select salary from employees where department_id = 40 )


