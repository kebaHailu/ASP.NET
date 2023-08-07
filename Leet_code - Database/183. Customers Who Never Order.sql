Select Customers.name as Customers 
from Customers LEFT JOIN orders 
ON Customers.id = orders.customerId 
where orders.CustomerId is NUll; 