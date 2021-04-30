
/* ) Using SQL Server CREATE INDEX statement 
to create a nonclustered index for multiple columns example.*/

CREATE INDEX ix_customers_name 
ON sales.customers(last_name, first_name)

GO
--Now, the query optimizer uses the index ix_customers_name to find the customer.
SELECT 
    customer_id, 
    first_name, 
    last_name
FROM 
    sales.customers
WHERE 
    last_name = 'Berg' AND 
    first_name = 'Monika';