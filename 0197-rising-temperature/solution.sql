-- Write your PostgreSQL query statement below
select w.id from Weather w where w.temperature > (select x.temperature from Weather x where x.recordDate = (w.recordDate - 1));
