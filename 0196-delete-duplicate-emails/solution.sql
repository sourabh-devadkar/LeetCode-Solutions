-- Write your PostgreSQL query statement below
delete from Person where (email, id) not in (select email, min(id) from Person group by email);
