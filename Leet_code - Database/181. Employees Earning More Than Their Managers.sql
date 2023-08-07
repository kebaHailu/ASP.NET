SELECT to_employ.Name as 'Employee' 
From Employee as to_employ, 
     Employee as to_manage 
WHERE to_employ.ManagerId = to_manage.Id 
And to_employ.Salary > to_manage.Salary;