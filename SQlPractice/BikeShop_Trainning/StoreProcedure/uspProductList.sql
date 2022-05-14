

CREATE or ALTER PROCEDURE uspProductList
	AS
	BEGIN
		SELECT
			product_name,
			list_price
		FROM 
			production.products
		ORDER BY
			list_price
	END;


---EXEC uspProductList;---

