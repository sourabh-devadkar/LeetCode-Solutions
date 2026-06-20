-- Write your PostgreSQL query statement below
With cte as 
(
    select machine_id, process_id, max(timestamp) - min(timestamp) as difference from Activity group by machine_id, process_id
)

select machine_id, round(avg(difference)::numeric, 3) as processing_time from cte group by machine_id;

